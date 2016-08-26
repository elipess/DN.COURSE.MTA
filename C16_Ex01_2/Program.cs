using System;
using System.Text;

namespace C16_Ex01_2
{

    class Program
    {
        public static StringBuilder hourGlass = new StringBuilder();
        public static int numOfLinesForHourGlass = 5;
        public static void main()
        {
            DrawHourGlass(numOfLinesForHourGlass);
            Console.WriteLine(hourGlass);
        }
        public static void DrawHourGlass(int i_NumOfLinesForHourGlass)
        {
            BuildTopPyramid(i_NumOfLinesForHourGlass);
            BuildTopPyramid(i_NumOfLinesForHourGlass);
        }
      
        public static void BuildTopPyramid(int i_SizeOfHourGlass)
        {
            int height = (i_SizeOfHourGlass + 1) / 2;
       
            for (int row = 0; row < height; row++)
            {
                for (int leftSpaces = 0; leftSpaces < row; leftSpaces++)
                {
                    hourGlass.Append(" ");
                }   
                for (int stars = 0; stars < 2 * (height - row); stars ++)
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
        public static void BuildButtomPyramid(int i_SizeOfHourGlass)
        {

            int height = (i_SizeOfHourGlass + 1) / 2;

            for (int row = 0; row < height; row++)
            {
                for (int leftSpaces = height ; row < leftSpaces; leftSpaces--)
                {
                    hourGlass.Append(" ");
                }
                for (int stars = 2 * (height - row); stars - row < (2 * height) + 1; stars--)
                {
                    hourGlass.Append("*");
                }
                for (int rightSpaces = height; row < rightSpaces ; rightSpaces--)
                {
                    hourGlass.Append(" ");
                }
                hourGlass.Append("\n");
            }

        }

    }
}
