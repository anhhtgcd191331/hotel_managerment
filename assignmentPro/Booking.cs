using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPro
{
    public class Booking
    {
        private string idBooking;
        private string nameHotel;
        private string standardRoom;
        private string roomNumber;
        private string checkIn;
        private string checkOut;
        private double contractDeposit;

        public Booking(string idBooking, string nameHotel, string standardRoom, string roomNumber, string checkIn, string checkOut, double contractDeposit)
        {
            this.idBooking = idBooking;
            this.nameHotel = nameHotel;
            this.standardRoom = standardRoom;
            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.contractDeposit = contractDeposit;
        }

        public override string ToString()
        {
            return "ID Booking: '" + this.idBooking
                + "', Name hotel: '" + this.nameHotel
                + "', Standrad room: '" + this.standardRoom
                + "', Room number: '" + this.roomNumber
                + "', Check in: '" + this.checkIn
                + "', Chek out: '" + this.checkOut
                + "', Contract Deposit: '" + this.contractDeposit;
        }
    }
}
