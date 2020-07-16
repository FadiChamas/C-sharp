/************************************************************
    PROGRAMME  :  Console Ex04

    OUTLINE    :  This programme prompts the user to enter in
                  a number, and will display all the numbers either
                  even, odd or divisible by 9.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 24, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_LoopEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables and set console settings
            bool boolExit = false;
            Console.Title = "Loop Exercise 04 Menu";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\tEnter a number: ");
            int numChosen = int.Parse(Console.ReadLine());
            Console.Clear();
            do // loop until exit boolean is true
            {
                //set options
                Console.WriteLine("\n\tThe number you entered was: " + numChosen);
                Console.WriteLine("\n\t1. Display all the even numbers from 0 until your number.");
                Console.WriteLine("\t2. Display all the odd numebrs from 0 until your number.");
                Console.WriteLine("\t3. Display all the number that are divisible by 9 from 0 to your number.");
                Console.WriteLine("\t0. Exit program.");
                Console.Write("\n\tChoose one: ");
                int numOption = int.Parse(Console.ReadLine());
                switch (numOption) //execute code depending on variable value
                {
                    case 0: //case 0 exit
                        {
                            Console.Write("\n\n\tAre you sure you want to exit? Press Y for Yes and N for No:");
                            string strExit = Console.ReadLine();
                            if (strExit == "Y" || strExit == "y") // if string is y exit variable true
                                boolExit = true; 
                            else if (strExit == "N" || strExit == "n") 
                                boolExit = false;
                            break;
                        }
                    case 1: //case 1 even numbers
                        {
                            // add 2 until numLoop is greater than numChosen
                            for (int numLoop = 0; numLoop <= numChosen; numLoop += 2)
                            {
                                Console.Write("\t" + numLoop);
                            }
                            break;
                        }
                    case 2: //case 2 odd numbers
                        {
                            // add 2 until numloop is greater than numchosen but start at 1
                            for (int numLoop = 1; numLoop <= numChosen; numLoop += 2)
                            {
                                Console.Write("\t" + numLoop);
                            }
                            break;
                        }
                    case 3: //case 3 divisble by 9
                        {
                            // add 9 until numloop is greater than numchosen
                            for (int numLoop = 0; numLoop <= numChosen; numLoop += 9)
                            {
                                Console.Write("\t" + numLoop);
                            }
                            break;
                        } 
                    default: //other
                        //state invalid
                        Console.WriteLine("\n\n\tInvalid input! Please enter 1, 2, 3, 0. Press enter to continue.");
                        break;
                }
                Console.WriteLine("\n\tPress enter to choose another option..");
                Console.ReadKey();
                Console.Clear();
            } while (!boolExit);
            Console.ReadKey();
        }
    }
}