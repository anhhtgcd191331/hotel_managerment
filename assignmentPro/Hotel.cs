using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPro
{
    public class Hotel
    {
        private string idHotel;
        private string nameHotel;
        private string address;
        private string roomNumber;
        private string standardRoom;
        private int floors;
        private double priceRoom;
        private string statusRoom;

        public Hotel(string idHotel, string nameHotel, string address, string roomNumber, string standardRoom, int floors, double priceRoom, string statusRoom)
        {
            this.idHotel = idHotel;
            this.nameHotel = nameHotel;
            this.address = address;
            this.roomNumber = roomNumber;
            this.standardRoom = standardRoom;
            this.floors = floors;
            this.priceRoom = priceRoom;
            this.statusRoom = statusRoom;
        }
        public void setIdHotel(string idHotel)
        {
            this.idHotel =idHotel;
        }
        public string getIdHotel()
        {
            return idHotel;
        }

        public void setNameHotel(string nameHotel)
        {
            this.nameHotel = nameHotel;
        }
        public string getNameHotel()
        {
            return nameHotel;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return address;
        }

        public void setRoomNumber(string roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        public string getRoomNumber()
        {
            return roomNumber;
        }

        public void setStandardRoom(string standardRoom)
        {
            this.standardRoom = standardRoom;
        }
        public string getStandardRoom()
        {
            return standardRoom;
        }

        public void setFloors(int floors)
        {
            this.floors = floors;
        }
        public int getFloors()
        {
            return floors;
        }

        public void setPriceRoom(double priceRoom)
        {
            this.priceRoom = priceRoom;
        }
        public double getPriceRoom()
        {
            return priceRoom;
        }

        public void setStatusRoom(string statusRoom)
        {
            this.statusRoom = statusRoom;
        }
        public string getStatusRoom()
        {
            return statusRoom;
        }

        public override string ToString()
        {
            return "ID hotel: '" + this.idHotel
                + "', Name hotel: '" + this.nameHotel
                + "', Address: '" + this.address
                + "', Room number: '" + this.roomNumber
                + "', Standrad room: '" + this.standardRoom
                + "', Floors: '" + this.floors
                + "', Price Room: '" + this.priceRoom
                + "', Status Room: '" + this.statusRoom;
        }
    }
}
