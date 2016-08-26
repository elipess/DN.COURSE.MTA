using System;
using System.Collections.Generic;
using System.Text;

namespace C16_Ex01_4
{
    class Program
    {

        public enum strType
        {
            Digits = 1, Letters = 2
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with size 10 :");

            int digitsOrLetters;
            bool isPalindrom = true;
            string strToAnalyze = GetStrFromConsole(out digitsOrLetters);

            switch (digitsOrLetters)
            {
                case 1:
                    {
                        isPalindrom = CheckIfStrIsPalindrom(strToAnalyze);
                        double avgOfDigits = CheckAvgOfStrDigits(strToAnalyze);

                        Console.WriteLine("String Statistics :");

                        if (isPalindrom)
                        {
                            Console.WriteLine("The string is Palindrom");

                        }
                        else
                        {
                            Console.WriteLine("The string is not Palindrom");

                        }

                        Console.WriteLine("The average of the digits in the string is " + avgOfDigits + " .");
                        break;
                    }
                case 2:
                    {
                        isPalindrom = CheckIfStrIsPalindrom(strToAnalyze);
                        int numOfCamelCaseLetters = CheckNumOfCamelLetters(strToAnalyze);
                        Console.WriteLine("String Statistics :");

                        if (isPalindrom)
                        {
                            Console.WriteLine("The string is Palindrom");

                        }
                        else
                        {
                            Console.WriteLine("The string is not Palindrom");

                        }
                        Console.WriteLine("The number of the Camel case letters is " + numOfCamelCaseLetters + ".");

                        break;
                    }

            }
        }


        public static string GetStrFromConsole(out int io_numericOrLetters)
        {
            bool goodInput = true;

            string o_strToAnalyze = "";

            io_numericOrLetters = 0;

            bool firstTimeAskForNumber = true;

            while (firstTimeAskForNumber || !goodInput)
            {
                 o_strToAnalyze = Console.ReadLine();

                 int numericStr;

                 bool digitsOnly = int.TryParse(o_strToAnalyze, out numericStr);

                 int numOFLetters = 0;

                 for(int i=0; i < o_strToAnalyze.Length; i++)
                 {
                     if(o_strToAnalyze[i] >= 'a' && o_strToAnalyze[i] <= 'z' || o_strToAnalyze[i] >= 'A' && o_strToAnalyze[i] <= 'Z')
                     {
                        numOFLetters++;
                     }
                 }
   
               
                 if(!digitsOnly && numOFLetters == 10 )
                 {
                     io_numericOrLetters = (int)strType.Letters;
                 }
                 else if(digitsOnly && o_strToAnalyze.Length == 10)
                 {
                     io_numericOrLetters = (int)strType.Digits;
                 }
                 else
                 {
                     Console.WriteLine("The input you entered is invalid. Please try again.");
                     goodInput = false;
                     io_numericOrLetters = (int)strType.Digits;
                 }

                 firstTimeAskForNumber = false;
            }
            
            return o_strToAnalyze;
           
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
                if (i_StrToAnalyze[i] >= 'A' && i_StrToAnalyze[i] <= 'Z')
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

            int sumOfDigitsOfSte = 0;
            double avgOfDigitsOfStr = 0;
            while (numericStr != 0)
            {
                sumOfDigitsOfSte += numericStr % 10;
                numericStr /= i_StrToAnalyze.Length;
            }

            return avgOfDigitsOfStr = sumOfDigitsOfSte / (double)i_StrToAnalyze.Length;

        }
      
    }
}
