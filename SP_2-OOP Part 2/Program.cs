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

        }
    }
}
