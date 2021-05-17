//using System;


//public class Program
//{
//    public int NumberOfWaysToTraverseGraph(int width, int height)
//    {
//        // Write your code here.

//        if (width == 1 || height == 1)
//        {
//            return 1;
//        }

//        int[,] heightWidthArray = new int[width, height];

//        for (int windx = 0; windx < width; windx++)
//        {
//            for (int hindx = 0; hindx < height; hindx++)
//            {
//                if (windx - 1 < 0 || hindx - 1 < 0)
//                {
//                    heightWidthArray[windx, hindx] = 1;
//                }
//                else
//                {
//                    heightWidthArray[windx, hindx] = heightWidthArray[windx - 1, hindx] + heightWidthArray[windx, hindx - 1];
//                }
//            }
//        }

//        return heightWidthArray[width - 1, height - 1];
//    }

//    static void Main(string[] args)
//    {
//        Program ns = new Program();
//        ns.NumberOfWaysToTraverseGraph(3, 2);
//    }
//}
