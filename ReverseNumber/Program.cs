using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumber = "";

            do
            {
                Console.Write("Enter a number (1000 - 9999): ");
                strNumber = Console.ReadLine();

                if (strNumber == "0")
                {
                    break;
                }
            } while (!validation(strNumber));
            

            int strConvertToNumber = Convert.ToInt32(ReverseNumber(strNumber));
            if (Convert.ToInt32(strNumber) > strConvertToNumber)
            {
                int result = Convert.ToInt32(strNumber) - strConvertToNumber;
                Console.WriteLine(strNumber + " - " + strConvertToNumber + " = " + result);
            }
            else
            {
                int result = strConvertToNumber - Convert.ToInt32(strNumber);
                Console.WriteLine(strConvertToNumber + " - " + strNumber + " = " + result);
            }

            Console.ReadKey();
        }

        public static string ReverseNumber(string strNumber)
        {
            string concat = "";
            int len = strNumber.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                concat += strNumber[i];
            }
            return concat;
        }

        public static bool validation(string strNumber)
        {
            if (strNumber == "")
            {
                Console.WriteLine("Please enter number between 1000 - 9999");
                return false;
            }
            return true;
        }
    }
}
