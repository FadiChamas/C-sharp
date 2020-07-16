/************************************************************
    PROGRAMME  :  Arrays Exercise 01

    OUTLINE    :  This programme displays how many spots are
                  left in each of the ICS3U1 sections.

    PROGRAMMER :  Fadi Chamas

    DATE       :  April 7th, 2020
 ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChamasF_ClassEnrollment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tNUMBER OF SEATS OPEN FOR EACH CS CLASS:\n");
            string[] strClasses = new string[] {"ICS3U1-04","ICS3U1-02","ICS3U1-01"};
            int[] intFilled = new int[] {21,20,26};
            int[] intTotal = new int[] {30,30,30};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n\n\t" + strClasses[i] + " has " +  (intTotal[i] - intFilled[i]) + " spots left");
            }
            Console.ReadKey();
        }
    }
}
