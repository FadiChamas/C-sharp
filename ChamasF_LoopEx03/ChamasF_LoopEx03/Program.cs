/************************************************************
    PROGRAMME  :  Console Ex03

    OUTLINE    :  This programme prompts the user to enter in
                  a number, and will display whether or not that
                  number is divisible by 9.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 24, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_LoopEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            //input number and declaring variables
            Console.WriteLine("Enter an Integer: ");
            string strInput = Console.ReadLine();
            int numTotal = 0;
            int counter = 0;
            int numColumn = 0;
            Console.WriteLine();
            foreach (char c in strInput) //repeat for every character in the input
            {
                numColumn = int.Parse(c.ToString()); //convert the character to string which gets converted to integer
                Console.Write(numColumn); //write the integer
                numTotal += numColumn; //add the integer to the other integers
                counter++; //increase counter
                if (counter == strInput.Length) //if counter = string length
                {
                    break; //break out
                }
                else
                {
                    Console.Write(" + "); //write a plus sign
                }
            }
            Console.Write(" = " + numTotal); //display an equals sign and the sum
            if (numTotal % 9 == 0) //if sum divided by 9 has no remainder 0
            {
                Console.WriteLine("\n" + numTotal + " mod 9 = 0");
                Console.WriteLine("\n" + numTotal + " is divisible by 9."); //output number and number is divisible by 9
            }
            else
            {
                Console.WriteLine("\n\n" + numTotal + " is NOT divisible by 9."); //output number and number is not divisible by 9
            }
            Console.ReadKey();
        }
    }
}