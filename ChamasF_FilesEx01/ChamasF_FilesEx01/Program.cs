/************************************************************
    PROGRAMME  :  Console Files Exercise 01

    OUTLINE    :  This programme prompts the user to enter in
                  a name and gross pay and outputs various
                  statistics.

    PROGRAMMER :  Fadi Chamas

    DATE       :  February 28, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ChamasF_FilesEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables and setup the console
            Console.Title = "Break in for loop";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\tEnter the Teacher's name: ");
            string strName = Console.ReadLine();
            Console.Write("\n\tEnter the Teacher's gross pay: ");
            string strPay = Console.ReadLine();
            decimal decPay = Convert.ToDecimal(strPay);
            decimal decTax = 0;
            //depending on pay, the tax changes
            if (decPay <= 3000)
            {
                decTax = decPay / 10;
            }
            else if (decPay <= 4000)
            {
                decTax = (decPay / 100) * 15;
            }
            else if (decPay <= 6000)
            {
                decTax = decPay / 5;
            }
            else if (decPay > 6000)
            {
                decTax = decPay / 4;
            }
            decimal decCPP = (decPay / 100) * (decimal)4.5;
            decimal decTPP = decPay / 20;
            decimal decUnion = decPay / 50;
            decimal decHealth = 120.00M;
            decimal decTotal = decPay - (decTax + decCPP + decTPP + decUnion + decHealth);
            //output the stats into the console
            Console.WriteLine("\n\tIncome Tax: " + decTax.ToString("C2"));
            Console.WriteLine("\n\tCCP: " + decCPP.ToString("C2"));
            Console.WriteLine("\n\tTeacher's PP: " + decTPP.ToString("C2"));
            Console.WriteLine("\n\tUnion Dues: " + decUnion.ToString("C2"));
            Console.WriteLine("\n\tHealth Plan: " + decHealth.ToString("C2"));
            Console.WriteLine("\n\tNet Pay: " + decTotal.ToString("C2"));
            //write the statistics to the file
            StreamWriter file = new StreamWriter("payCheck.txt");
            file.WriteLine("Teacher's Name: " + strName);
            file.WriteLine("Gross Amount: \t" + decPay.ToString("C2"));
            file.WriteLine("Income Tax: \t" + decTax.ToString("C2"));
            file.WriteLine("CCP: \t\t" + decCPP.ToString("C2"));
            file.WriteLine("Teacher's PP: \t" + decTPP.ToString("C2"));
            file.WriteLine("Union Dues: \t" + decUnion.ToString("C2"));
            file.WriteLine("Health Plan: \t" + decHealth.ToString("C2"));
            file.WriteLine("Net Pay: \t" + decTotal.ToString("C2"));
            Console.WriteLine("\n\tYour paycheck has been written to the file payCheck.txt");
            file.Close();
            Console.ReadKey();
        }
    }
}
