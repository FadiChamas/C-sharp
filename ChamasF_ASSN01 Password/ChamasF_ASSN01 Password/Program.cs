using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
namespace ChamasF_ASSN01_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup console and declare variables for checking password using Regex
            Console.Title = "ASSN01 Password Checking";
            Console.ForegroundColor = ConsoleColor.Cyan;
            StreamWriter output = new StreamWriter("passwords.txt");
            var minCount = new Regex(".{8,}");
            var charSymbol = new Regex(@"[/\|!#\$%&/\()=\?»«@£§€{}\.\-\[\];'<>_,<>]");
            var charSpace = new Regex("[\\s]");
            var charCaps = new Regex("[A-Z]+");
            var charNum = new Regex("[0-9]+");
            int numTotal = 0;
            ArrayList ArrayPasswords = new ArrayList();
            do
            {
                Console.Write("\n\n\tEnter a password: ");
                string strInput = Console.ReadLine();
                numTotal = 0;
                if (!minCount.IsMatch(strInput))
                    Console.WriteLine("\tInvalid password length: Minimum 8 characters!");
                else
                    numTotal++;
                if (!charSymbol.IsMatch(strInput))
                    Console.WriteLine("\tPassword needs at least 1 special character!");
                else
                    numTotal++;
                if (!charSpace.IsMatch(strInput))
                    Console.WriteLine("\tPassword shouldn't have any spaces!");
                else
                    numTotal++;
                if (!charCaps.IsMatch(strInput))
                    Console.WriteLine("\tPassword needs at least 1 uppercase letter!");
                else
                    numTotal++;
                if (!charNum.IsMatch(strInput))
                    Console.WriteLine("\tPassword needs at least 1 number!");
                else
                    numTotal++;
                ArrayPasswords.Add(strInput);
            } while (numTotal < 5);
            //outputs password entered and then puts it in a file
            Console.WriteLine("\n\tPassword input successful!\n\tPASSWORDS ENTERED:");
            foreach (string i in ArrayPasswords)
            {
                Console.Write("\n\t" + i);
                output.WriteLine(i);
            }
            output.Close();
            Console.ReadKey();
        }
    }
}
