using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ProjectContext())
            {

                //Case1: add employee

                //add data on table employee
                //Employee e1 = new Employee();
                //e1.EmployeeName = "Abdullah";
                //e1.EmployeeSalary = 1000;
                //e1.EmployeeSsn = 12345678;
                //e1.EmployeeAge = 20;

                //context.employees.Add(e1);
                //context.SaveChanges();

                Console.WriteLine("Register User");

                Employee e1 = new Employee();

                Console.WriteLine("Enter name: ");
                e1.EmployeeName = Console.ReadLine();

                Console.WriteLine("Enter age: ");
                e1.EmployeeAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Enetr Salary: ");
                e1.EmployeeSalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Ssn: ");
                e1.EmployeeSsn = int.Parse(Console.ReadLine());

                context.employees.Add(e1);
                context.SaveChanges();

                //case2: delete employee
                Console.WriteLine("Enter employee ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                Employee employee = context.employees.FirstOrDefault(e => e.EmployeeId == id);
                if (employee == null)
                {
                    Console.WriteLine("Employee not found.");

                }
                else
                {
                    context.employees.Remove(employee);
                    context.SaveChanges();
                }
            }//end comtext

        }
    }
}
