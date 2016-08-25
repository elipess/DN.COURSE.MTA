using System;
using System.Collections.Generic;
using System.Text;

namespace C16_Ex01_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Q5();
        }

        public static void Q5()
        {
            int i_num = getNumFromUser();
            int biggestDigit = extractBiggestDigitFromNum(i_num);
            int smallestDigit = extractSmallestDigitFromNum(i_num);
            int amountOfLargestFromUnity = getAmountOfLargestFromUnity(i_num);
            int amountOfSmallestFromUnity = getAmountOfSmallestFromUnity(i_num);

            Console.WriteLine(
@"The biggest digit in your number is: {0}.
And the smallest digit is: {1}.
However, there is {2} digits that is bigger then your unity digit,
and {3} digits that is smaller than your unity digit.
Very important information, ha?",
biggestDigit, smallestDigit, amountOfLargestFromUnity, amountOfSmallestFromUnity);
        }

        private static int getAmountOfSmallestFromUnity(int i_num)
        {
            int unity = i_num % 10;
            int res = 0;

            i_num /= 10; ///to ignore the unity digit
            while (i_num > 0)
            {
                if (i_num % 10 < unity)
                {
                    res++;
                }

                i_num /= 10;
            }

            return res;
        }

        private static int getAmountOfLargestFromUnity(int i_num)
        {
            int unity = i_num % 10;
            int res = 0;
            
            //to ignore the unity digit
            i_num /= 10; 
            while (i_num > 0)
            {
                if (i_num % 10 > unity) 
                {
                    res++;
                }

                i_num /= 10;
            }

            return res;
        }

        private static int extractSmallestDigitFromNum(int i_num)
        {
            int minDigit = i_num % 10;

            while (i_num != 0)
            {
                int digit = i_num % 10;
                if (digit < minDigit)
                {
                    minDigit = digit;
                }

                i_num /= 10;
            }

            return minDigit;
        }

        private static int extractBiggestDigitFromNum(int i_num)
        {
            int maxDigit = i_num % 10;

            while (i_num != 0)
            {
                int digit = i_num % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }

                i_num /= 10;
            }

            return maxDigit;
        }

        private static int getNumFromUser()
        {
            int res;
            string i_numStr;

            Console.WriteLine("Hello! Please enter a number and press Enter: ");
            //try to get good input from user untill he finnaly does that...
            while (true)
            {
                try
                {
                    i_numStr = Console.ReadLine();
                    res = int.Parse(i_numStr);
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please type a number... ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please write the number propperly: ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please write a number between {0} and {1}: ", int.MinValue, int.MaxValue);
                }
            }

            return res;
        }
    }
}
