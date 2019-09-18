using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterClassLibrary
{
    public class Seat
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool Booked { get; set; } = false;
        public string AdultOrChild { get; set; }

        public Seat(string fname, string lname, bool booked, string adultOrChild)
        {
            Fname = fname;
            Lname = lname;
            Booked = booked;
            AdultOrChild = adultOrChild;
        }
        public string DisplayName()
        {
            return $"{Fname} {Lname}";
        }
    }
}
