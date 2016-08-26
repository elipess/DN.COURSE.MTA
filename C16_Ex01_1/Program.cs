using System;
using System.Text;

namespace C16_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            Q1(); 
        }

        private static void Q1()
        {
            const int k_baseOfConvertion = 2;
            const int k_numbersToAsk = 4;

            int[] decimalNumbers = GetInputFromUser(k_numbersToAsk);
            StringBuilder[] binNumbers = ConvertToBin(decimalNumbers, k_baseOfConvertion);

            Console.WriteLine("The binary numbers are: ");
            foreach (StringBuilder binNums in binNumbers)
            {
                Console.WriteLine(binNums);
            }

            int avgDigitsOfBinaryNum = GetAvgNumOfDigits(ref binNumbers);
            int generalAvgOfNumber = GetGeneralAvg(ref decimalNumbers);
            int numOfAcendingOrder = GetAcending(ref decimalNumbers);
            int numOfDescendingOrder = GetDescending(ref decimalNumbers);

            Console.WriteLine("\nThe avarege number of digits in the binary number is " + avgDigitsOfBinaryNum + " .");
            Console.WriteLine("The general avarege of the inserted numbers is " + generalAvgOfNumber + " .");
            Console.WriteLine("There are " + numOfAcendingOrder + " numbers which are an ascending series and " + numOfDescendingOrder + " are descending.");
        }

        private static StringBuilder[] ConvertToBin(int[] i_decimalNumbers, int i_conversionBase)
        {
            StringBuilder[] o_binStrings = new StringBuilder[i_decimalNumbers.Length];
            int counter = 0;

            foreach (int dec in i_decimalNumbers)
            {
                o_binStrings[counter] = new StringBuilder();
                int decReplicka = dec;
                while (decReplicka != 0) 
                {
                    int digit = decReplicka % 2;
                    o_binStrings[counter].Insert(0, digit);
                    decReplicka /= 2;
                }

                counter++;
            }

            return o_binStrings;
        }

        private static int[] GetInputFromUser(int i_amountOfNumbers)
        {
            int[] resArr = new int[i_amountOfNumbers];
            int i = 0;

            Console.WriteLine("Please enter {0} numbers with 3 digits each", i_amountOfNumbers);

            while (i < i_amountOfNumbers)
            {
                bool succedded;
                string decimalStr;
                int decimalNumber;

                do
                {
                    decimalStr = Console.ReadLine();
                    succedded = int.TryParse(decimalStr, out decimalNumber);
                    if (!succedded)
                    {
                        Console.WriteLine("The input you entered is invalid. Please try again.");
                    }
                }
                while (!succedded);

                if (decimalStr.Length == 3 && decimalNumber > 0)
                {
                    resArr[i++] = decimalNumber; 
                }
                else
                {
                    Console.WriteLine("The input you entered is invalid. Please try again.");
                }
            }

            return resArr;
        }

        public static int GetAvgNumOfDigits(ref StringBuilder[] io_binary)
        {
            int o_avg = 0, sumOfDigits = 0;

            for (int i = 0; i < io_binary.Length; i++)
            {
                sumOfDigits += io_binary[i].Length;
            }

            o_avg = sumOfDigits / io_binary.Length;

            return o_avg;
        }

        public static int GetGeneralAvg(ref int[] io_desimal)
        {
            int o_avg = 0, sumOfDesimalNum = 0;

            for (int i = 0; i < io_desimal.Length; i++ )
            {
                sumOfDesimalNum += io_desimal[i]; 
            }

            o_avg = sumOfDesimalNum / io_desimal.Length;
            
            return o_avg;
        }

        public static int GetAcending(ref int[] io_desimal)
        {
            int o_numOfAscending = 0;

            for (int i = 0; i < io_desimal.Length; i++)
            {
                if ((io_desimal[i] % 10 > (io_desimal[i] / 10) % 10) && ((io_desimal[i] / 10) % 10 > io_desimal[i] / 100)) 
                {
                    o_numOfAscending++;
                }
            }

            return o_numOfAscending;
        }

        public static int GetDescending(ref int[] io_desimal)
        {
            int o_numOfDescending = 0;

            for (int i = 0; i < io_desimal.Length; i++)
            {
                if ((io_desimal[i] % 10 < (io_desimal[i] / 10) % 10) && ((io_desimal[i] / 10) % 10 < io_desimal[i] / 100)) 
                {
                    o_numOfDescending++;
                }
            }

            return o_numOfDescending;
        }
    }
}
