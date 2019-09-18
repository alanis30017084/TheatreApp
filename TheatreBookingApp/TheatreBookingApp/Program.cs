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
            Theater.theater1[0, 0] = new Seat("Terry", "Smith", true, "adult");
            Console.WriteLine($"" +
                $"Seat 1A Booked: {Theater.theater1[0, 0].Booked}\n" +
                $"Seat 1A Name: {Theater.theater1[0, 0].DisplayName()}\n" +
                $"Seat 1A - adult or child: {Theater.theater1[0, 0].AdultOrChild}");

            Console.WriteLine();

            Theater.theater1[1, 0] = new Seat("Murphy", "Smith", true, "child");
            Console.WriteLine($"" +
                $"Seat 2A Booked: {Theater.theater1[1, 0].Booked}\n" +
                $"Seat 2A Name: {Theater.theater1[1, 0].DisplayName()}\n" +
                $"Seat 2A - adult or child: {Theater.theater1[1, 0].AdultOrChild}");

            Console.ReadKey();
            
        }
    }
}
