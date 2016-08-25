using System;
using System.Text;

namespace C16_Ex01_1
{
    class Program
    {
      
        public static void Main()
        {
            const int k_baseOfConvertion = 2;
            const int k_numbersToAsk = 4;

            int[] desimalNumbers = new int[k_numbersToAsk]; 
            string[] strBinaryNumbers = new string[k_numbersToAsk]; 
            bool goodInput = true;
            string desimalStr = "";
            int desimalNumber = 0;
            int i = 0;
 
            Console.WriteLine("Please enter " + k_numbersToAsk + " numbers with 3 digits each:");

            while( i < k_numbersToAsk )
            {
                try
                {
                    desimalStr = Console.ReadLine();
                    desimalNumber = int.Parse(desimalStr);   
                }
                catch(Exception e)
                {
                    goodInput = false;
                }

                if (goodInput != false && desimalStr.Length == 3 && desimalNumber > 0)
                {
                    string binary = Convert.ToString(desimalNumber, k_baseOfConvertion);

                    desimalNumbers[i] = desimalNumber;
                    strBinaryNumbers[i++] = binary;

                }
                else
                {
                    Console.WriteLine("The input you entered is invalid. Please try again.");
                }

                goodInput = true;
            }

            Console.Write("The binary numbers are: ");
            for( i = 0 ; i < k_numbersToAsk ; i++)
            {
                Console.Write(strBinaryNumbers[i] + " ");
            }

            int avgDigitsOfBinaryNum = GetAvgNumOfDigits(ref strBinaryNumbers);
            int generalAvgOfNumber = GetGeneralAvg(ref desimalNumbers);
            int numOfAcendingOrder = GetAcending(ref desimalNumbers);
            int numOfDescendingOrder = GetDescending(ref desimalNumbers);

            Console.WriteLine("\nThe avarege number of digits in the binary number is " + avgDigitsOfBinaryNum + " .");
            Console.WriteLine("The general avarege of the inserted numbers is " + generalAvgOfNumber + " .");
            Console.WriteLine("There are " + numOfAcendingOrder +" numbers which are an ascending series and " + numOfDescendingOrder + " are descending.");

        }

        public static int GetAvgNumOfDigits(ref string[] io_binary)
        {
            int avg = 0, sumOfDigits = 0;

            for (int i = 0; i < io_binary.Length; i++)
            {
                sumOfDigits += io_binary[i].Length;
            }

            avg = (sumOfDigits / io_binary.Length);

            return avg;
        }
        public static int GetGeneralAvg(ref int[] io_desimal)
        {
            int avg = 0 , sumOfDesimalNum = 0;

            for (int i = 0; i < io_desimal.Length; i++ )
            {
                sumOfDesimalNum += io_desimal[i]; 
            }

            avg = (sumOfDesimalNum / io_desimal.Length) ; 
            
            return avg;
        }
        public static int GetAcending(ref int[] io_desimal)
        {
            int numOfAscending = 0;

            for (int i = 0; i < io_desimal.Length; i++)
            {
                
                if(((io_desimal[i])%10 > ((io_desimal[i])/10)%10) && (((io_desimal[i])/10)%10 > io_desimal[i]/100))
                {
                    numOfAscending++;
                }

            }

            return numOfAscending;
        }
        public static int GetDescending(ref int[] io_desimal)
        {
            int numOfDescending = 0;

            for (int i = 0; i < io_desimal.Length; i++)
            {
                if(((io_desimal[i])%10 < ((io_desimal[i])/10)%10) && (((io_desimal[i])/10)%10 < io_desimal[i]/100))
                {
                    numOfDescending++;
                }

            }

            return numOfDescending;
        }
    }
}
