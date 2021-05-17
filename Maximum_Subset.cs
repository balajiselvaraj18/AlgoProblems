//using System;

//public class Program
//{
//    public static int MaxSubsetSumNoAdjacent(int[] array)
//    {
//        // Write your code here.
//        //MaxSubsetSumNoAdjacent() max (i-2) + array[i]

//        int[] MaxSums = new int[array.Length];
//        if (array.Length == 0)
//            return 0;

//        MaxSums[0] = array[0];
//        if (array.Length > 1)
//        {
//            if (array[0] > array[1])
//            {
//                MaxSums[1] = array[0];
//            }
//            else
//            {
//                MaxSums[1] = array[1];
//            }
//            for (int idx = 2; idx < array.Length; idx++)
//            {
//                MaxSums[idx] = Math.Max(MaxSums[idx - 1], MaxSums[idx - 2] + array[idx]);
//            }
//        }

//        return MaxSums[array.Length - 1];
//    }
//    static void Main(string[] args)
//    {
//        int[] input = { 75, 105, 120, 75, 90, 135 };
//        Program.MaxSubsetSumNoAdjacent(input);
//    }
//}
