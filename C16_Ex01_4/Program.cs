using System;
using System.Collections.Generic;
using System.Text;

namespace C16_Ex01_4
{
    public class Program
    {
        public enum strType
        {
            Digits = 1,
            Letters = 2
        }

        public static void Main(string[] args)
        {
            Q4();
        }

        private static void Q4()
        { 
            strType digitsOrLetters;
            string strToAnalyze = GetStrFromUser(out digitsOrLetters);

            printStats(strToAnalyze, digitsOrLetters);
        }

        private static void printStats(string strToAnalyze, strType digitsOrLetters)
        {
            Console.WriteLine("String Statistics:");
            string palindromMsg = CheckIfStrIsPalindrom(strToAnalyze) ? null : "not";
            Console.WriteLine("The string is {0} a palindrom", palindromMsg);
            switch (digitsOrLetters)
            {
                case strType.Digits:
                    {
                        double avgOfDigits = CheckAvgOfStrDigits(strToAnalyze);

                        Console.WriteLine("The average of the digits in the string is {0}.", avgOfDigits);

                        break;
                    }

                case strType.Letters:
                    {
                        int numOfCamelCaseLetters = CheckNumOfCamelLetters(strToAnalyze);

                        Console.WriteLine("The number of the Camel case letters is {0}.", numOfCamelCaseLetters);

                        break;
                    }
            }
        }

        public static string GetStrFromUser(out strType io_numericOrLetters)
        {
            int i_inputInt;
            string io_inputStr;

            do
            {
                Console.WriteLine("Please type a 10 long string that contains only numbers or English letters:");
                io_inputStr = Console.ReadLine();
                if (io_inputStr.Length != 10) 
                {
                    Console.WriteLine("Error - Please type 10 letters or 10 digits");
                    continue;
                }

                if (int.TryParse(io_inputStr, out i_inputInt))
                {
                    io_numericOrLetters = strType.Digits;
                   
                    break;
                }
                else
                {
                    if(CheckIfStringIsAllLetters(io_inputStr))
                    {
                        io_numericOrLetters = strType.Letters;

                        break;
                    }
                }
            }
            while (true);

            return io_inputStr;
        }

        private static bool CheckIfStringIsAllLetters(string i_string)
        {
            bool o_res = true;

            foreach (char ch in i_string)
            {
                if (char.IsLetter(ch) == false)  
                {
                    o_res = false;
                }
            }

            return o_res;
        }

        public static bool CheckIfStrIsPalindrom(string i_StrToAnalyze)
        {            
            int length = i_StrToAnalyze.Length;
            bool o_IsPalindrom = true;

            for (int i = 0; i < length / 2; i++)
            {
                if (i_StrToAnalyze[i] != i_StrToAnalyze[length - i - 1])
                {
                    o_IsPalindrom = false;
                }
            }

            return o_IsPalindrom;
        }

        public static int CheckNumOfCamelLetters(string i_StrToAnalyze)
        {
            int numOFCamelCaseLetters = 0;

            for (int i = 0; i < i_StrToAnalyze.Length; i++)
            {
                if (char.IsUpper(i_StrToAnalyze[i]))
                {
                    numOFCamelCaseLetters++;
                }
            }

            return numOFCamelCaseLetters;
        }

        public static double CheckAvgOfStrDigits(string i_StrToAnalyze)
        {
            int numericStr;
            bool digitsOnly = int.TryParse(i_StrToAnalyze, out numericStr);
            int sumOfDigitsOfStr = 0;
            double avgOfDigitsOfStr = 0;

            while (numericStr != 0)
            {
                sumOfDigitsOfStr += numericStr % 10;
                numericStr /= i_StrToAnalyze.Length;
            }

            avgOfDigitsOfStr = sumOfDigitsOfStr / (double)i_StrToAnalyze.Length;

            return avgOfDigitsOfStr;
        }
    }
}
