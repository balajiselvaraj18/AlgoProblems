//using System;

//public class Program
//{
//    int[] temparr = new int { 0, 0, 0 };
//    public static int[] FindThreeLargestNumbers(int[] array)
//    {
//        for (int idx = 0; inx < array.Length; idx++)
//        {
//            helperMethod(array[idx], 2);
//        }
//        // Write your code here.
//        return temparr;
//    }

//    private void helperMethod(int val, int idx)
//    {
//        if(temparr[idx] > val)
//        {
//            if(idx == 2)
//            {
//                temparr[0] = temparr[1];
//                temparr[1] = temparr[2];
//                temparr[2] = val;
//            }
//            else if(idx = 1)
//            {
//                temparr[0] = temparr[1];
//                temparr[1] = val;
//            }
//            else
//            {
//                temparr[0] = val;
//            }
//        }
//        else if(temparr[idx] < val)
//        {
//            temparr[idx] = val;
//        }
//        else
//        {
//            return helperMethod(val, idx - 1);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Program.FindThreeLargestNumbers(new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 });
//    }
//}
