//using System;

//public class Program
//{
//    public static int LongestPeak(int[] array)
//    {
//        // Write your code here.
//        int indx = 1;
//        int tempCntr = 0;
//        int cntr = 1;
//        int finalCntr = 0;

//        while (indx < array.Length - 1)
//        {

//            if ((indx - 1 >= 0 && indx + 1 <= array.Length - 1) && (array[indx - 1] < array[indx]) && (array[indx + 1] < array[indx]))
//            {
//                tempCntr = indx;
//                cntr = 1;
//                while (tempCntr - 1 >= 0 && (array[tempCntr - 1] < array[tempCntr]))
//                {
//                    cntr++;
//                    tempCntr--;
//                }
//                tempCntr = indx;
//                while (tempCntr + 1 <= array.Length - 1 && (array[tempCntr + 1] < array[tempCntr]))
//                {
//                    cntr++;
//                    tempCntr++;
//                }
//                indx = tempCntr;

//            }
//            else { indx++; }

//            if (cntr > finalCntr && cntr > 1)
//                finalCntr = cntr;
//        }

//        return finalCntr;
//    }

//    static void Main(string[] args)
//    {
//        var input = new int[] { 5, 4, 3, 2, 1, 2, 10, 12 };
//        Program.LongestPeak(input);
//    }
//}
