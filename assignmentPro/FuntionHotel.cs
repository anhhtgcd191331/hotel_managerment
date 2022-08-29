using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPro
{
    public class FuntionHotel
    {
        private static List<Hotel> hotels = new List<Hotel>();
        private static List<Booking> bookings = new List<Booking>();    
        public void displayInformation()
        {
            foreach(Hotel hotel in hotels)
            {
                Console.WriteLine(hotel.ToString());
            }
        }
        public void displayRoomEmty()
        {
            foreach (Hotel hotel in hotels)
            {
                if (hotel.getStatusRoom().Equals("emty"))
                {
                    Console.WriteLine(hotel.ToString());
                }
            }
        }
        public void addHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public void editHotel(string idHotel)
        {
            foreach (Hotel hotel in hotels)
            {
                if (hotel.getIdHotel().Equals(idHotel))
                {
                    Console.Write("Name hotel: ");
                    string name = Console.ReadLine();
                    Console.Write("Address hotel: ");
                    string address = Console.ReadLine();
                    Console.Write("Room number: ");
                    string roomNumber = Console.ReadLine();
                    Console.Write("Standard Room: ");
                    string standard = Console.ReadLine();
                    Console.Write("Floors room: ");
                    int floors = int.Parse(Console.ReadLine());
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Status Room: ");
                    string status = Console.ReadLine();
                    hotel.setNameHotel(name);
                    hotel.setAddress(address);
                    hotel.setRoomNumber(roomNumber);
                    hotel.setStandardRoom(standard);    
                    hotel.setFloors(floors);
                    hotel.setPriceRoom(price);
                    hotel.setStatusRoom(status);
                }
            }
        }
        public void remove(string id)
        {
            foreach(Hotel hotel in hotels)
            {
                if (hotel.getIdHotel().Equals(id))
                {
                    hotels.Remove(hotel);
                }
            }
        }

        public void findHotel(string infor)
        {
            foreach (Hotel hotel in hotels)
            {
                if(hotel.getIdHotel().Equals(infor)|| hotel.getNameHotel().Equals(infor)|| hotel.getStandardRoom().Equals(infor)) 
                {
                    Console.Write(hotel.ToString());
                }
            }
        }
        public void addBooking(Booking booking)
        {
            bookings.Add(booking);
        }
        public void displayBooking()
        {
            foreach(Booking booking in bookings)
            {
                Console.WriteLine(booking.ToString());
            }
        }

        public string checkNameHotel()
        {
            while (true)
            {
                Console.Write("Name hotel: ");
                string name = Console.ReadLine();
                foreach (Hotel hotel in hotels)
                {
                    if (hotel.getNameHotel().Equals(name) && hotel.getStatusRoom().Equals("emty"))
                    {
                        return name;
                    }
                    else
                    {
                        Console.WriteLine("Name not found in hotel.");
                        Console.WriteLine("Please enter name againt!!!!");
                    }
                }
            }
        }
        public string checkStandardRoom()
        {
            while (true)
            {
                Console.Write("Standard Room: ");
                string standard = Console.ReadLine();
                foreach (Hotel hotel in hotels)
                {
                    if (hotel.getStandardRoom().Equals(standard) && hotel.getStatusRoom().Equals("emty"))
                    {
                        return standard;
                    }
                    else
                    {
                        Console.WriteLine("Standard Room not found in hotel.");
                        Console.WriteLine("Please enter againt!!!!");
                    }
                }
            }
        }
        public string checkRoomNumber()
        {
            while (true)
            {
                Console.Write("Room number: ");
                string roomNumber = Console.ReadLine();
                foreach (Hotel hotel in hotels)
                {
                    if (hotel.getRoomNumber().Equals(roomNumber) && hotel.getStatusRoom().Equals("emty"))
                    {
                        hotel.setStatusRoom("booked");
                        return roomNumber;
                    }
                    else
                    {
                        Console.WriteLine("Room Number not found in hotel.");
                        Console.WriteLine("Please enter againt!!!!");
                    }
                }
            }
        }

    }
}
