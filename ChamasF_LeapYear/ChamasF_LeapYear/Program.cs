using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Leap Year";
            do
            {
                Console.Write("\nEnter a year: ");
                int numYear = int.Parse(Console.ReadLine());
                if (numYear % 100 == 0)
                {
                    if (numYear % 400 == 0)
                    {
                        Console.WriteLine(numYear + " is a leap year");
                    }
                    else
                    {
                        Console.WriteLine(numYear + " is not a leap year");
                    }
                }
                else
                {
                    if (numYear % 4 == 0)
                    {
                        Console.WriteLine(numYear + " is a leap year");
                    }
                    else
                    {
                        Console.WriteLine(numYear + " is not a leap year");
                    }
                }
            } while (true);
        }
    }
}