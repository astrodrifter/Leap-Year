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
                Console.WriteLine("Enter year");
                string entry = Console.ReadLine();
                int year = Int32.Parse(entry);
                IsLeapYear(year);
                Console.WriteLine("Another year? \nEnter Yes or No.");
                string another = Console.ReadLine();
                if (another == "No") {
                    quit = true;
                }
            }

        }
        public static bool IsLeapYear(int year) {
            if (year % 4 == 0) {
                Console.WriteLine("Yes. {0} is a Leap year", year);
                return true;
            } else if (year % 100 == 0 && year % 400 == 0) {
                Console.WriteLine("Yes. {0} is a Leap year", year);
                return true;
            } else {
                Console.WriteLine("No. {0} is not Leap year", year);
                return true;
            }
        }
    }
}
