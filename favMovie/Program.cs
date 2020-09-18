using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace favMovie
{
    class Program
    {
        static void Main(string[] args)
        {


            string firstName = "David";

            string favMovie = "The Matrix";

            Console.WriteLine($"Good morning {firstName.ToLower()}, I just want to let you know that your favourite movie, {favMovie.ToLower()}, sucks! Have a good day...");

            favMovie = favMovie.ToUpper();

            Console.WriteLine(favMovie);

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace('A', '@');
            favMovie = favMovie.Replace('E', '3');

            Console.WriteLine(favMovie);



            Console.WriteLine("D D D D       M       M ");
            Console.WriteLine("D      D      M M   M M ");
            Console.WriteLine("D      D      M M   M M ");
            Console.WriteLine("D      D      M   M   M ");
            Console.WriteLine("D      D      M       M ");
            Console.WriteLine("D      D      M       M ");
            Console.WriteLine("D D D D       M       M ");



            Console.ReadLine();





            Console.ReadLine();





        }
    }
}
