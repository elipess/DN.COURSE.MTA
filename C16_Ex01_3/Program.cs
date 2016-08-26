using System;
using System.Collections.Generic;
using System.Text;
using SimpleHourGlass = C16_Ex01_2.Program;


namespace C16_Ex01_3
{
    class Program
    {
        public static void main()
        {

            Console.WriteLine("Please enter the number of lines for the sand machine:");

            int numOfLinesForSandWatch = GetNumOfLinesToPrint();

            SimpleHourGlass.DrawHourGlass(numOfLinesForSandWatch);
        }

        public static int GetNumOfLinesToPrint()
        {
            int o_numOfLines = 0;
            bool goodInput = true;
            bool firstTimeAskForNumber = true;

            while (firstTimeAskForNumber || goodInput)
            {
                String steNumber = Console.ReadLine();

                goodInput = Int32.TryParse(steNumber, out o_numOfLines);

                if (goodInput != true)
                {
                    Console.WriteLine("The input you entered is invalid. Please try again.");
                    firstTimeAskForNumber = false;
                }
                else
                {
                    Console.WriteLine(o_numOfLines);
                }
            }

            return o_numOfLines;
        }
    }
}
