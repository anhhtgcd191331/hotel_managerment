using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPro
{
    public class Program
    {
        static FuntionHotel funtionHotel = new FuntionHotel();
        static void Main(string[] args)
        {
            addSomeHotel();
            int choice = -1;
            while (choice !=0)
            {
                Console.WriteLine("Hotel Management System");
                Console.WriteLine("1. Display all hotel");
                Console.WriteLine("2. Add new hotel");
                Console.WriteLine("3. Update information of hotel");
                Console.WriteLine("4. Remove hotel");
                Console.WriteLine("5. Find information hotel");
                Console.WriteLine("6. Display emty room");
                Console.WriteLine("7. Booking room");
                Console.WriteLine("8. Display booking room");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice here: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        funtionHotel.displayInformation();
                        break;
                    case 2:
                        addNewHotel();
                        break;
                    case 3:
                        Console.Write("Enter id hotel here: ");
                        string id = Console.ReadLine();
                        funtionHotel.editHotel(id);
                        break;
                    case 4:
                        Console.Write("Enter id hotel here: ");
                        string idRemove = Console.ReadLine();
                        funtionHotel.remove(idRemove);
                        break;
                    case 5:
                        Console.Write("Enter id hotel here: ");
                        string idFind = Console.ReadLine();
                        funtionHotel.findHotel(idFind);
                        break;
                    case 6:
                        funtionHotel.displayRoomEmty();
                        break;
                    case 7:
                        addNewBooking();
                        break;
                    case 8:
                        funtionHotel.displayBooking();
                        break;
                    case 0:
                        Console.WriteLine("You have successfully exited the program");
                        break;
                    default: Console.WriteLine("Please enter choice again!!!");
                        break;
                }
            }
        }
        public static void addSomeHotel()
        {
            funtionHotel.addHotel(new Hotel("H1", "Muong Thanh","270 Vo Nguyen Giap", "301", "vip", 3, 3000000, "emty"));
            funtionHotel.addHotel(new Hotel("H12", "Hoang Anh", "38 Nguyen Cong Tru", "302", "normal", 3, 3000000, "emty"));
            funtionHotel.addHotel(new Hotel("H12", "Hoang Anh", "38 Nguyen Cong Tru", "303", "normal", 3, 3000000, "maintenance"));
            funtionHotel.addHotel(new Hotel("H134", "Novotel", "36 Bach Dang", "401", "vip", 4, 3000000, "emty"));
            funtionHotel.addHotel(new Hotel("H134", "Novotel", "36 Bach Dang", "402", "vip", 4, 3000000, "booked"));
            funtionHotel.addHotel(new Hotel("H134", "Novotel", "36 Bach Dang", "121", "vip", 12, 3000000, "booked"));
            funtionHotel.addHotel(new Hotel("H112", "Golden bay", "Le Van Duyet", "123", "president", 12, 10000000, "emty"));
        }
        public static void addNewHotel()
        {
            Console.Write("Id hotel: ");
            string id = Console.ReadLine();
            Console.Write("Name hotel: ");
            string name = Console.ReadLine();
            Console.Write("Address hotel: ");
            string address = Console.ReadLine();
            Console.Write("Room number: ");
            string roomNumber = Console.ReadLine();
            Console.Write("Standard Room: ");
            string standard = Console.ReadLine();
            Console.Write("Floors room: ");
            int floors =int.Parse(Console.ReadLine());  
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Status Room: ");
            string status = Console.ReadLine();
            Hotel hotel = new Hotel(id, name, address, roomNumber, standard, floors, price, status);
            funtionHotel.addHotel(hotel);
        }
        public static void addNewBooking()
        {
            Console.Write("Id Booking: ");
            string id = Console.ReadLine();
            string name = funtionHotel.checkNameHotel();
            string standard = funtionHotel.checkStandardRoom();
            string roomNumber = funtionHotel.checkRoomNumber();
            Console.Write("Check In(dd/mm/yy): ");
            string checkIn = Console.ReadLine();
            Console.Write("Check Out(dd/mm/yy): ");
            string checkOut = Console.ReadLine();
            Console.Write("Contract Deposit: ");
            double contract = double.Parse(Console.ReadLine());
            Booking booking = new Booking(id,name,standard,roomNumber,checkIn,checkOut,contract);
            funtionHotel.addBooking(booking);
        }

    }
}
