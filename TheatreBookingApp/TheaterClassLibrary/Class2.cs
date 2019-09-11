using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterClassLibrary
{
    public class Seat
    {
        public bool Booked { get; set; } = false;
        public string AdultOrChild { get; set; }

        public Seat(bool booked, string adultOrChild)
        {
            Booked = booked;
            AdultOrChild = adultOrChild;
        }
    }
}
