/************************************************************
    PROGRAMME  :  Console Minimum of Three

    OUTLINE    :  This programme prompts the user to enter in
                  three numbers, and will display the number
                  that has the smallest value.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 18, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_MinOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Minimum of Three";
            Console.WriteLine("Enter 3 integers each followed by the enter key:\n");
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());
            int numThird = int.Parse(Console.ReadLine());
            if (numFirst < numSecond)
            {
                if (numFirst < numThird)
                {
                    Console.WriteLine("\nMinimum value: " + numFirst);
                }
                else
                {
                    Console.WriteLine("\nMinimum value: " + numThird); 
                }
            }
            else if (numSecond < numThird)
            {
                Console.WriteLine("\nMinumum value: " + numSecond);
            }
            else
            {
                Console.WriteLine("\nMinimum value: " + numThird);
            }
            Console.ReadKey();
        }
    }
}