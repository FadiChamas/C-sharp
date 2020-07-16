/************************************************************
    PROGRAMME  :  Console Ex05

    OUTLINE    :  This programme prompts the user to enter in
                  two strings and will display them in a unique
                  fashion.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 24, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamasF_LoopEx05
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables and setup console
            Console.Title = "Loop Ex05 Pattern Display";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\tPlease enter the first character: ");
            string strFirst = Console.ReadLine();
            Console.Write("\n\tPlease enter the second character: ");
            string strSecond = Console.ReadLine();
            Console.Write("\n\tHow many times you want it to repeat: ");
            int numRepeat;
            //while integer isnt integer, tell them to enter valid integer
            while (!int.TryParse(Console.ReadLine(), out numRepeat))
                Console.Write("\n\tEnter a valid integer: ");
            for (int numRows = 0; numRows <= numRepeat; numRows++) // for rows
            {
                Console.WriteLine(); // write the line
                for (int numAcross = 0; numAcross < numRows; numAcross++) // for how many across
                {
                    if (numRows % 2 == 0) //if odd start with second
                        Console.Write("\t" + strSecond.ToUpper());
                    else //else start with first
                        Console.Write("\t" + strFirst.ToUpper());
                }
            }
            Console.ReadKey();
        }
    }
}
