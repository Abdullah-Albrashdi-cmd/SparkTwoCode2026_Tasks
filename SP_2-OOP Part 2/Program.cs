namespace SP_2_OOP_Part_2
{
    public class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }

        public void displayRoom()
        {
            string status;
            if (isAvailable)
            {
                status = "Available";
            }
            else
            {
                status = "Booked";
            }

            Console.WriteLine("Room " + roomNumber + " | Type: " + roomType + " | Price: OMR " + pricePerNight + " | Status: " + status);
        }
    }

    public class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = "Not Assigned";
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }

        public void displayGuest()
        {
            Console.WriteLine(guestId + " | " + guestName + " | Room: " + roomNumber + " | Check-in: " + checkInDate + " | Nights: " + totalNights);
        }

        
        public double calculateTotalCost(double pricePerNight)
        {
            return totalNights * pricePerNight;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            //load rooms
            rooms.Add(new Room(101, "Single", 25.3, true));
            rooms.Add(new Room(102, "Single", 26.0, true));
            rooms.Add(new Room(201, "Double", 40.2, true));
            rooms.Add(new Room(202, "Double", 45.0, true));
            rooms.Add(new Room(301, "Suite", 91.0, true));
            rooms.Add(new Room(302, "Suite", 111.1, true));

            bool running = true;
            while (running)
            {
                Console.WriteLine("");
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine("");

                switch (choice)
                {
                    case "1": AddNewRoom(rooms); break;
                    case "2": RegisterNewGuest(guests); break;
                    //case "3": BookRoom(guests, rooms); break;
                    //case "4": ViewAllRooms(rooms); break;
                    //case "5": ViewAllGuests(guests); break;
                    case "6": SearchFilterRooms(rooms); break;
                    //case "7": GuestBookingStatistics(guests, rooms); break;
                    //case "8": UpdateRoomPrice(rooms); break;
                    //case "9": GuestLookupByName(guests); break;
                    //case "10": RoomTypeBreakdown(rooms); break;
                    //case "11": CheckOutGuest(guests, rooms); break;
                    //case "12": RemoveUnavailableRooms(rooms, guests); break;
                    //case "13": ExtendGuestStay(guests, rooms); break;
                    //case "14": HighestRevenueBooking(guests, rooms); break;
                    //case "15": GuestPagination(guests); break;
                    case "0": running = false; Console.WriteLine("Thankyou"); break;
                    default: Console.WriteLine("Invalid choice, please try again"); break;
                }
            }

            //Case 01 Add New Room
            static void AddNewRoom(List<Room> rooms)
            {

                int roomNumber = 0;
                bool validRoomNumber = false;
                while (!validRoomNumber)
                {
                    Console.Write("Enter room number: ");
                    string input = Console.ReadLine();
                    bool parsed = int.TryParse(input, out roomNumber);
                    if (parsed && roomNumber > 0)
                    {
                        validRoomNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("pleas enter a valid positive whole number");
                    }
                }

                string roomType = "";
                bool validType = false;
                while (!validType)
                {
                    Console.Write("Enter room type (Single/Double/Suite): ");
                    roomType = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(roomType))
                    {
                        validType = true;
                    }
                    else
                    {
                        Console.WriteLine("Input cannot be empty please try again");
                    }
                }

                double price = 0;
                bool validPrice = false;
                while (!validPrice)
                {
                    Console.Write("Enter price per night: ");
                    string input = Console.ReadLine();
                    bool parsed = double.TryParse(input, out price);
                    if (parsed && price > 0)
                    {
                        validPrice = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid positive number");
                    }
                }

                bool exists = rooms.Any(r => r.roomNumber == roomNumber);
                if (exists)
                {
                    Console.WriteLine("Error: room with number " + roomNumber + " already exists");
                    return;
                }

                Room newRoom = new Room(roomNumber, roomType, price, true);
                rooms.Add(newRoom);

                Console.WriteLine("Room added successfully");
                Console.WriteLine("Room Number: " + roomNumber + " | Type: " + roomType + " | Price: OMR " + price);
                Console.WriteLine("Total rooms now: " + rooms.Count);
            }

            //Case 02 Register New Guest 
            static void RegisterNewGuest(List<Guest> guests)
            {
                string name = "";
                bool valname = false;

                while (!valname)
                {
                    Console.WriteLine("Enter your name: ");
                    name = Console.ReadLine();
                    
                    if (name != null)
                    {
                        valname = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again");
                    }
                }

                string checkInD = "";
                bool valdate = false;

                while (!valdate)
                {
                    Console.WriteLine("Enter check in date: ");
                    checkInD = Console.ReadLine();
                    if (checkInD != null)
                    {
                        valdate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalied input, try again");

                    }
                }

                int numOfN = 0;
                bool checkNum = false;

                while (!checkNum)
                {
                    Console.WriteLine("Enter number of nights: ");
                    numOfN = Convert.ToInt32(Console.ReadLine());
                    if (numOfN != 0)
                    {
                        checkNum = true;
                    }
                    else
                    {
                        Console.WriteLine("please enter valid positive number");

                    }
                }

                int nextNumber = guests.Count + 1;
                string guestId;
                if (nextNumber < 10)
                {
                    guestId = "G00" + nextNumber;
                }
                else if (nextNumber < 100)
                {
                    guestId = "G0" + nextNumber;
                }
                else
                {
                    guestId = "G" + nextNumber;
                }

                Guest newGuest = new Guest(guestId, name, checkInD, numOfN);
                guests.Add(newGuest);

                Console.WriteLine("Guest registered successfully");
                Console.WriteLine("Guest ID: " + guestId + " | Name: " + name + " | Check-in: " + checkInD + " | Nights: " + numOfN);
            }

            //Case 03 Book a Room for a Guest 

            //Case 06 Search & Filter Rooms
            static void SearchFilterRooms(List<Room> rooms)
            {
                bool back = false;
                while (!back)
                {
                    Console.WriteLine("Filter rooms menu");
                    Console.WriteLine("1. Show all available rooms");
                    Console.WriteLine("2. Filter by room type");
                    Console.WriteLine("3. Filter by max price");
                    Console.WriteLine("4. Room price statistics");
                    Console.WriteLine("0. Back");
                    Console.Write("Enter your choice: ");
                    string subChoice = Console.ReadLine();

                    if (subChoice == "1")
                    {
                        List<Room> available = rooms.Where(r => r.isAvailable).OrderBy(r => r.pricePerNight).ToList();
                        Console.WriteLine("Matches found: " + available.Count());
                        if (available.Count == 0)
                        {
                            Console.WriteLine("No rooms found ");
                        }
                        else
                        {
                            foreach (Room r in available)
                            {
                                r.displayRoom();
                            }
                        }
                    }
                    else if (subChoice == "2")
                    {
                        Console.Write("Enter room type to filter by: ");
                        string type = Console.ReadLine();

                        List<Room> filtered = rooms.Where(r => r.roomType.ToLower() == type.ToLower()).ToList();
                        Console.WriteLine("Matches found: " + filtered.Count());
                        if (filtered.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria ");
                        }
                        else
                        {
                            foreach (Room r in filtered)
                            {
                                r.displayRoom();
                            }
                        }
                    }
                    else if (subChoice == "3")
                    {
                        double maxPrice = 0;
                        bool validPrice = false;
                        while (!validPrice)
                        {
                            Console.Write("Enter maximum price: ");
                            string input = Console.ReadLine();
                            bool parsed = double.TryParse(input, out maxPrice);
                            if (parsed && maxPrice > 0)
                            {
                                validPrice = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid positive number");
                            }
                        }

                        List<Room> filtered = rooms.Where(r => r.isAvailable && r.pricePerNight <= maxPrice).OrderBy(r => r.pricePerNight).ToList();
                        Console.WriteLine("Matches found: " + filtered.Count());
                        if (filtered.Count == 0)
                        {
                            Console.WriteLine("No rooms foundfor the selected criteria.");
                        }
                        else
                        {
                            foreach (Room r in filtered)
                            {
                                r.displayRoom();
                            }
                        }
                    }
                    else if (subChoice == "4")
                    {
                        if (rooms.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        else
                        {
                            int totalRooms = rooms.Count();
                            int availableRooms = rooms.Count(r => r.isAvailable);
                            
                            double avgPrice = rooms.Average(r => r.pricePerNight);
                            double minPrice = rooms.Min(r => r.pricePerNight);
                            double maxPriceValue = rooms.Max(r => r.pricePerNight);

                            Console.WriteLine("Total rooms: " + totalRooms);
                            Console.WriteLine("Available rooms: " + availableRooms);
                            Console.WriteLine("Average price: OMR " + Math.Round(avgPrice, 2));
                            Console.WriteLine("Cheapest price: OMR " + Math.Round(minPrice, 2));
                            Console.WriteLine("Most expensive price: OMR " + Math.Round(maxPriceValue, 2));
                        }
                    }
                    else if (subChoice == "0")
                    {
                        back = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, try again");
                    }
                }
            }




        }
    }
}
