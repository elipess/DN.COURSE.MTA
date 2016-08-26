using System;
using System.Text;
using SimpleHourGlass = C16_Ex01_2.Program;

namespace C16_Ex01_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the number of lines for the sand machine:");
            int numOfLinesForSandWatch = GetNumOfLinesToPrint();
            StringBuilder hourGlass = SimpleHourGlass.CreateHourGlass(numOfLinesForSandWatch);
            Console.WriteLine(hourGlass);
        }

        public static int GetNumOfLinesToPrint()
        {
            int o_numOfLines = 0;
            bool goodInput = false;

            do
            {
                string strNumber = Console.ReadLine();

                goodInput = int.TryParse(strNumber, out o_numOfLines);

                if (goodInput == false || o_numOfLines <= 0)
                {
                    Console.WriteLine("The input you entered is invalid. Please try again.");
                    goodInput = false;
                }
            }
            while (goodInput == false);

            return o_numOfLines;
        }
    }
}
