//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static List<int[]> FourNumberSum(int[] array, int targetSum)
//    {
//        // Write your code here.
//        Dictionary<int, List<int[]>> DictOfPairs = new Dictionary<int, List<int[]>>();

//        List<int[]> lstPairvals = new List<int[]>();
//        for (int headIndx = 1; headIndx < array.Length - 1; headIndx++)
//        {
//            for (int forwIndx = headIndx + 1; forwIndx < array.Length; forwIndx++)
//            {
//                int CurrentSum = array[headIndx] + array[forwIndx];
//                int diff = targetSum - CurrentSum;

//                if (DictOfPairs.ContainsKey(diff))
//                {
//                    foreach (int[] pairs in DictOfPairs[diff])
//                    {
//                        int[] pairValues = { pairs[0], pairs[1], array[headIndx], array[forwIndx] };
//                        lstPairvals.Add(pairValues);
//                    }
//                }
//            }


//            for (int revIndx = 0; revIndx < headIndx; revIndx++)
//            {
//                int CurrSum = array[headIndx] + array[revIndx];
//                int[] pairs = { array[revIndx], array[headIndx] };

//                if (!DictOfPairs.ContainsKey(CurrSum))
//                {
//                    List<int[]> lstpairsvals = new List<int[]>();
//                    lstpairsvals.Add(pairs);
//                    DictOfPairs.Add(CurrSum, lstpairsvals);
//                }
//                else
//                {
//                    DictOfPairs[CurrSum].Add(pairs);
//                }

//            }
//        }
//        return lstPairvals;
//    }


//}
