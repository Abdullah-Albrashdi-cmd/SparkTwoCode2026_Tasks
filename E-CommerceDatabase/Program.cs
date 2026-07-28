using System;
using System.Collections.Generic;
using System.Linq;
using E_CommerceDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceDatabase
{
    internal class Program
    {
        // Shared DbContext - created ONCE, here, so every function below reuses
        // the exact same instance instead of each function opening its own.
        static AppDbContext context = new AppDbContext();
        // Shared login state - 0 means "nobody is logged in".
        // Set by Login(), read by any function that requires a logged-in user,
        // reset back to 0 by Logout().
        static int loggedInUserId = 0;
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        // ===================== FUNCTIONS =====================
        // Every function below talks to the console itself AND uses the
        // shared "context" field declared above - never create a new
        // AppDbContext() inside any of these functions.
        static void RegisterUser()
        {
            // TODO: implement (see Part 3 requirements)
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            bool emailTaken = context.Users.Any(u => u.Email == email);
            if (emailTaken)
            {
                Console.WriteLine("An account with this email already exists");
                return;
            }

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            User newUser = new User
            {
                Name = name,
                Email = email,
                Password = password
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            Console.WriteLine("Registration successful Your User ID is " + newUser.UserId );
        
        }
        static void Login()
        {
            // TODO: implement - on success, set loggedInUserId = <found user's Id>
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            User foundUser = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (foundUser == null)
            {
                Console.WriteLine("invalid email or password");
                return;
            }

            loggedInUserId = foundUser.UserId;
            Console.WriteLine("Welcome back " + foundUser.Name );
        }
        static void AddCategory()
        {
            // TODO: implement
            Console.Write("Enter category name: ");
            string categoryName = Console.ReadLine();

            Console.Write("Enter category description: ");
            string description = Console.ReadLine();

            Category newCategory = new Category
            {
                CategoryName = categoryName,
                Description = description
            };

            context.Categories.Add(newCategory);
            context.SaveChanges();

            Console.WriteLine("Category added with ID " + newCategory.CategoryId);
        
        }
        static void AddProduct()
        {
            // TODO: implement
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product price: ");
            decimal price;
            try
            {
                price = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid price");
                return;
            }

            Console.Write("Enter product stock quantity: ");
            int stock;
            try
            {
                stock = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid stock quantity");
                return;
            }

            Console.Write("Enter the category ID for this product: ");
            int categoryId;
            try
            {
                categoryId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid category id");
                return;
            }

            Category selectedCategory = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (selectedCategory == null)
            {
                Console.WriteLine("category not found");
                return;
            }

            Product newProduct = new Product
            {
                Name = name,
                Price = price,
                Stock = stock,
                CategoryId = categoryId
            };

            context.Products.Add(newProduct);
            context.SaveChanges();

            Console.WriteLine("Product added with ID " + newProduct.ProductId);
        }
        static void ViewAllProducts()
        {
            // TODO: implement
            Console.Write("Filter by Category ID: ");
            string input = Console.ReadLine();

            List<Product> products = context.Products.Include(p => p.Category).ToList();

            if (!string.IsNullOrWhiteSpace(input))
            {
                int categoryId;
                try
                {
                    categoryId = int.Parse(input);
                    products = products.Where(p => p.CategoryId == categoryId).ToList();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid category ID entered");
                }
            }

            if (products.Count == 0)
            {
                Console.WriteLine("No products found");
                return;
            }

            Console.WriteLine("-Products-");
            foreach (Product p in products)
            {
                string categoryName;
                if (p.Category == null)
                {
                    categoryName = "unknown";
                }
                else
                {
                    categoryName = p.Category.CategoryName;
                }
                Console.WriteLine(p.ProductId + p.Name + " $ " + p.Price + " Category: " + categoryName + " Stock: " + p.Stock);
            }
        }
        static void PlaceOrder()
        {
            // TODO: implement - check loggedInUserId != 0 first
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to place an order");
                return;
            }

            List<Product> products = context.Products.ToList();

            Console.WriteLine("-Available Products-");
            foreach (Product p in products)
            {
                Console.WriteLine(p.ProductId + ". " + p.Name + " $ " + p.Price + " ( Stock: " + p.Stock + ")");
            }

            Order newOrder = new Order
            {
                UserId = loggedInUserId,
                OrderDate = DateTime.Now
            };

            context.Orders.Add(newOrder);
            context.SaveChanges();

            bool addingProducts = true;
            bool addedAtLeastOne = false;

            while (addingProducts)
            {
                Console.Write("Enter Product ID to add (or 0 to finish): ");
                int productId;
                try
                {
                    productId = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid input");
                    continue;
                }

                if (productId == 0)
                {
                    addingProducts = false;
                    continue;
                }

                Product selectedProduct = context.Products.FirstOrDefault(p => p.ProductId == productId);
                if (selectedProduct == null)
                {
                    Console.WriteLine("Product not found");
                    continue;
                }

                Console.Write("Enter quantity: ");
                int quantity;
                try
                {
                    quantity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid quantity");
                    continue;
                }

                if (quantity <= 0)
                {
                    Console.WriteLine("quantity must be greater than zer");
                    continue;
                }

                OrderProduct newOrderProduct = new OrderProduct
                {
                    OrderId = newOrder.OrderId,
                    ProductId = productId,
                    Quantity = quantity
                };

                context.OrderProducts.Add(newOrderProduct);
                context.SaveChanges();

                addedAtLeastOne = true;
                Console.WriteLine("Added " + quantity +" " + selectedProduct.Name + " to the order");
            }

            if (!addedAtLeastOne)
            {
                context.Orders.Remove(newOrder);
                context.SaveChanges();
                Console.WriteLine("No products were added order cancelled");
                return;
            }

            Console.WriteLine("Order " + newOrder.OrderId + " placed successfully");
        
        }
        static void ViewMyOrders()
        {
            // TODO: implement - check loggedInUserId != 0 first
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to view your orders");
                return;
            }
 
            List<Order> myOrders = context.Orders.Where(o => o.UserId == loggedInUserId).ToList();
 
            if (myOrders.Count == 0)
            {
                Console.WriteLine("You have no orders yet");
                return;
            }
 
            Console.WriteLine("-My Orders-");
            foreach (Order o in myOrders)
            {
                Console.WriteLine("Order " + o.OrderId + " placed on " + o.OrderDate);
            }
        }
        static void ViewOrderDetails()
        {
            // TODO: implement
        }
        static void AddReview()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }
        static void ViewReviewsForProduct()
        {
            // TODO: implement
        }
        static void Logout()
        {
            // TODO: implement - reset loggedInUserId back to 0
        }
    }
}