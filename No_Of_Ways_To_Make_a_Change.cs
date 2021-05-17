//using System;

//public class Program
//{
//    public static int NumberOfWaysToMakeChange(int n, int[] denoms)
//    {
//        // Write your code here.
//        int[] waysArray = new int[n + 1];
//        waysArray[0] = 1;

//        int denomination_Amount = 0;
//        for (int idx = 0; idx < denoms.Length; idx++)
//        {
//            denomination_Amount = denoms[idx];
//            for (int windx = 1; windx <= n; windx++)
//            {
//                if (denomination_Amount <= windx)
//                {
//                    waysArray[windx] = waysArray[windx] + waysArray[windx - denomination_Amount];
//                }
//            }
//        }

//        return waysArray[n];
//    }

//    static void Main(string[] args)
//    {
//        int[] input = { 1, 5, 10, 25 };
//        Program.NumberOfWaysToMakeChange(10, input);
//    }
//}
