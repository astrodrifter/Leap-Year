using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear {
    class Program {
        static void Main(string[] args) {
            bool quit = false;
            while (quit != true) {
                string entry;
                Console.WriteLine("Enter year");
                entry = Console.ReadLine();
                int year = Int32.Parse(entry);

                if (year % 4 == 0) {
                    Console.WriteLine("Yes. {0} is a Leap year", year);

                } else if (year % 100 == 0 && year % 400 == 0) {
                    Console.WriteLine("Yes. {0} is a Leap year", year);

                } else {
                    Console.WriteLine("No. {0} is not Leap year", year);
                }

                Console.WriteLine("Another year? \nEnter Yes or No.");
                string another = Console.ReadLine();
                if (another == "No") {
                    quit = true;
                }
            }
        }
    }
}
