//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static List<int> SpiralTraverse(int[,] array)
//    {
//        // Write your code here.
//        int startRow = 0;
//        int endRow = array.GetLength(0) - 1;
//        int startCol = 0;
//        int endCol = array.GetLength(1) - 1;
//        List<int> lstSpiralArr = new List<int>();


//        while (startRow <= endRow && startCol <= endCol)
//        {
//            for (int indx = startCol; indx <= endCol; indx++)
//            {
//                lstSpiralArr.Add(array[startRow, indx]);
//            }


//            for (int indx = startRow + 1; indx <= endRow; indx++)
//            {
//                lstSpiralArr.Add(array[indx, endCol]);
//            }

//            for (int indx = endCol - 1; indx >= startCol; indx--)
//            {
//                if (startRow == endRow)
//                {
//                    break;
//                }

//                lstSpiralArr.Add(array[endRow, indx]);
//            }

//            for (int indx = endRow - 1; indx > startRow; indx--)
//            {
//                if (startCol == endCol)
//                {
//                    break;
//                }
//                lstSpiralArr.Add(array[indx, startCol]);
//            }

//            startRow++;
//            startCol++;
//            endRow--;
//            endCol--;
//        }

//        return lstSpiralArr;
//    }
//    static void Main(string[] args)
//    {
//        int[,] input = {
//            {1, 2, 3, 4},
//            {12, 13, 14, 5},
//            {11, 16, 15, 6},
//            {10, 9, 8, 7},
//        };
//        Program.SpiralTraverse(input);
//    }
//}
