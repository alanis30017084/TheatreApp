using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterClassLibrary;

namespace TheatreBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater.theater1[0, 0] = new Seat(true, "adult");
            Console.WriteLine($"" +
                $"Seat 1A Booked: {Theater.theater1[0, 0].Booked}\n" +
                $"Seat 1A - adult or child: {Theater.theater1[0, 0].AdultOrChild}");
        }
    }
}
