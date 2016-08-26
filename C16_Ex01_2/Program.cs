using System;
using System.Text;

namespace C16_Ex01_2
{
    public class Program
    {
        public static void Main()
        {
            Q2();
        }

        private static void Q2()
        {
            const int k_numOfLinesForHourGlass = 5;

            StringBuilder hourGlass = CreateHourGlass(k_numOfLinesForHourGlass);
            Console.WriteLine(hourGlass);
        }

        public static StringBuilder CreateHourGlass(int i_NumOfLinesForHourGlass)
        {
            StringBuilder res = new StringBuilder();

            if (i_NumOfLinesForHourGlass % 2 == 0) 
            {
                i_NumOfLinesForHourGlass++;
            }

            BuildTopPyramid(i_NumOfLinesForHourGlass, ref res);
            BuildButtomPyramid(i_NumOfLinesForHourGlass, ref res);

            return res;
        }

        public static void BuildTopPyramid(int i_SizeOfHourGlass, ref StringBuilder hourGlass)
        {
            int height = (i_SizeOfHourGlass + 1) / 2;
       
            for (int row = 0; row < height; row++)
            {
                for (int leftSpaces = 0; leftSpaces < row; leftSpaces++)
                {
                    hourGlass.Append(" ");
                }

                for (int stars = 0; stars < i_SizeOfHourGlass - (row * 2); stars++) 
                {
                    hourGlass.Append("*");
                }

                 for (int rightSpaces = 0; rightSpaces < row; rightSpaces++)
                {
                    hourGlass.Append(" ");
                }    

                hourGlass.Append("\n");
            }
        }

        public static void BuildButtomPyramid(int i_SizeOfHourGlass, ref StringBuilder hourGlass)
        {
            ////for 1 height sand clock we dont need buttom...
            if (i_SizeOfHourGlass > 1) 
            {
                string reversedString = ReverseString(hourGlass.ToString());
                DeleteMiddleRow(ref reversedString);
                hourGlass.Append(reversedString);
            }
        }

        private static void DeleteMiddleRow(ref string io_reversedString)
        {
            int indexOfStar = io_reversedString.IndexOf('*');
            indexOfStar = (indexOfStar * 2) + 1; ////calculating the num of chars to delete from the string
            io_reversedString = io_reversedString.Remove(0, indexOfStar);
        }

        private static string ReverseString(string i_str)
        {
            char[] arr = i_str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
