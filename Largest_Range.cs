//using System;
//using System.Collections.Generic;

//public class Program
//{
//    static void Main(String[] args)
//    {
//        Program.LargestRange(new int[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6 });
//    }
//    public static int[] LargestRange(int[] array)
//    {
//        // Write your code here.
//        int[] range = new int[2];
//        int Longest = 0;

//        HashSet<int> allNos = new HashSet<int>();

//        foreach (int vals in array)
//        {
//            allNos.Add(vals);
//        }

//        foreach (int vals in array)
//        {
//            if (allNos.Contains(vals) == false)
//            {
//                continue;
//            }

//            allNos.Remove(vals);
//            int cuurentLength = 1;
//            int Left = vals - 1;
//            int Right = vals + 1;

//            while (allNos.Contains(Left))
//            {
//                allNos.Remove(Left);
//                Left--;
//                cuurentLength++;

//            }

//            while (allNos.Contains(Right))
//            {
//                allNos.Remove(Right);
//                Right++;
//                cuurentLength++;
//            }

//            if (cuurentLength > Longest)
//            {
//                Longest = cuurentLength;
//                range = new int[] { Left + 1, Right - 1 };
//            }
//        }
//        return range;
//    }
//}
