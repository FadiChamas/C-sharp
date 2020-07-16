/************************************************************
    PROGRAMME  :  Files Ex02 Gift Shop

    OUTLINE    :  This programme reads informaation from a file
                  and uses that information to write to another
                  file.

    PROGRAMMER :  Fadi Chamas

    DATE       :  March 6, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ChamasF_GiftShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables and setup console
            string strValue;
            string[] strArray;
            double dblInput1, dblInput2, dblTotal = 0;
            Console.Title = "FILES EX02 Gift Shop";
            Console.ForegroundColor = ConsoleColor.Cyan;
            //if file exists write to it the output
            if (File.Exists("purchase.txt"))
            {
                StreamReader inFile = new StreamReader("purchase.txt");
                StreamWriter outFile = new StreamWriter("invoice.txt");
                while ((strValue = inFile.ReadLine()) != null)
                {
                    string strName = "";
                    strArray = strValue.Split(' ');
                    dblInput1 = double.Parse(strArray[strArray.Length - 1]);
                    dblInput2 = double.Parse(strArray[strArray.Length - 2]);
                    for (int i = 0; i < (strArray.Length - 2); i++)
                    {
                        strName += strArray[i] + " ";
                    }
                    Console.WriteLine("\n\t{0:N2} x {1:C} {2}{3:C}", dblInput2, dblInput1, strName, (dblInput1 * dblInput2));
                    outFile.WriteLine("\n\t{0:N2} x {1:C} {2}{3:C}", dblInput2, dblInput1, strName, (dblInput1 * dblInput2));
                    dblTotal += (dblInput1 * dblInput2);
                }
                Console.WriteLine("\n\n\tSuccessfully written to 'invoice.txt'");
                outFile.WriteLine("\n\n\tTotal Cost is {0:C}", dblTotal);
                inFile.Close();
                outFile.Close();
            }
            //otherwise make an error
            else
            {
                Console.WriteLine("ERROR: No 'purchase.txt' file found!");
            }
            Console.ReadKey();
        }
    }
}
