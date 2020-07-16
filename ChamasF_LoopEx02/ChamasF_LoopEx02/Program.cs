/************************************************************
    PROGRAMME  :  Console Ex02

    OUTLINE    :  This programme prompts the user to enter in
                  a number, and will display every number that
                  that has 3 subtracted from the previous number
                  until the number exceeds -10.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 24, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_LoopEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Loop Ex02"; //set title
            Console.ForegroundColor = ConsoleColor.Cyan; //change console color
            bool exit = false; //declare variable
            do
            {
                Console.Write("\n\tEnter an integer not divisible by 2: ");
                int numDivisble = int.Parse(Console.ReadLine()); //declare variable equal to input
                if (numDivisble % 2 == 0 || numDivisble < 0) //if said variable is divisible by 2 or negative
                {
                    continue;
                    Console.Write("\n\tEnter an integer not divisible by 2: "); //continue on
                }
                else
                {
                    while (numDivisble > -10) //while number is greater than -10
                    {
                        Console.Write("\t" + numDivisble); //output number
                        numDivisble -= 3; //subtract 3 every time
                        exit = true; //set exit to true
                    }
                }
            } while (!exit);
            Console.ReadKey();
        }
    }
}
