//using System;

//public class Program
//{
//    public static int[] FindThreeLargestNumbers(int[] array)
//    {
//        int[] temparr = new int[3] {Int32.MinValue, Int32.MinValue, Int32.MinValue };
//        for (int idx = 0; idx < array.Length; idx++)
//        {
//            helperMethod(array[idx], 2, temparr);
//        }
//        // Write your code here.
//        return temparr;
//    }

//    private static void helperMethod(int val, int idx, int[] temparr)
//    {
//        if (temparr[idx] < val)
//        {
//            if (idx == 2)
//            {
//                temparr[0] = temparr[1];
//                temparr[1] = temparr[2];
//                temparr[2] = val;
//            }
//            else if (idx == 1)
//            {
//                temparr[0] = temparr[1];
//                temparr[1] = val;
//            }
//            else
//            {
//                temparr[0] = val;
//            }
//        }
//        else
//        {
//            if ((idx - 1) >= 0)
//            {
//                helperMethod(val, idx - 1, temparr);
//            }
//            else
//            {
//                return;
//            }
//        }
//        //else
//        //{
//        //    helperMethod(val, idx - 1, temparr);
//        //}
//    }

//    static void Main(string[] args)
//    {
//        Program.FindThreeLargestNumbers(new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 });
//    }
//}
