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
                    case "3": BookRoom(guests, rooms); break;
                    case "4": ViewAllRooms(rooms); break;
                    case "5": ViewAllGuests(guests); break;
                    case "6": SearchFilterRooms(rooms); break;
                    case "7": GuestBookingStatistics(guests, rooms); break;
                    case "8": UpdateRoomPrice(rooms); break;
                    case "9": GuestLookupByName(guests); break;
                    case "10": RoomTypeBreakdown(rooms); break;
                    case "11": CheckOutGuest(guests, rooms); break;
                    case "12": RemoveUnavailableRooms(rooms, guests); break;
                    case "13": ExtendGuestStay(guests, rooms); break;
                    case "14": HighestRevenueBooking(guests, rooms); break;
                    case "15": GuestPagination(guests); break;
                    case "0": running = false; Console.WriteLine("Thankyou"); break;
                    default: Console.WriteLine("Invalid choice, please try again"); break;
                }
            }
        
        }
    }
}
