using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFilm("Matrix Revolutions");
            DisplayFilm("Matrix Revolutions", 200);
        }
        static void DisplayFilm(string movie, int runtime = 90)
        {
            Console.WriteLine($"{movie} - {runtime} minutes");
        }
    }
}
