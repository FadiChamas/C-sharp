/************************************************************
    PROGRAMME  :  Console Loops Ex01

    OUTLINE    :  This programme displays all integers between
                  0 and 25 using three different types of loops.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 24, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_LoopEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFOR LOOP: )\n");
            for (int numFor = 0; numFor <= 25; numFor++) //for number = 0 less than 25, add 1 each time
            {
                Console.Write(numFor + " "); //output the number and a space

            }
            int numWhile = 0;
            Console.WriteLine("\n\nWHILE LOOP: )\n");
            while (numWhile <= 25) //while number less than or equal to 25
            {
                Console.Write(numWhile + " "); //output number and space
                numWhile++; //increase number by 1
            }
            int numDo = 0;
            Console.WriteLine("\n\nDO LOOP: )\n");
            do
            {
                Console.Write(numDo + " "); //output number and space
                numDo++; //increase number by 1
            } while (numDo <= 25); //while number is less than or equal to 25.
            Console.ReadKey();
        }
    }
}
