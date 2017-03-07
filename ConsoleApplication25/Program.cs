using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game game = new Game(1, 5, 3, 2, 6, 4, 7, 0, 8);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();

        }
    }
}
