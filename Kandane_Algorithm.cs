//using System;

//public class Program
//{
//    public static int KadanesAlgorithm(int[] array)
//    {
//        // Write your code here.

//        int MaxEnding = array[0];
//        int MaxSoFar = array[0];


//        for (int idx = 1; idx < array.Length; idx++)
//        {
            
//                MaxEnding = Math.Max(MaxEnding + array[idx], array[idx]);
//                MaxSoFar = Math.Max(MaxSoFar, MaxEnding);
            
//        }

//        return MaxSoFar;
//    }
//    static void Main(string[] args)
//    {
//        int[] input = { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 };
//        Program.KadanesAlgorithm(input);
//    }
//}