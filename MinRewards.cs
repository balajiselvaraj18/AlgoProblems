//using System;

//public class Program
//{
//    public static int MinRewards(int[] scores)
//    {
//        // Write your code here.
//        if (scores.Length == 0)
//            return 0;
//        int[] minrewards = new int[scores.Length];
//        int cntr = 0;
//        for (int idx = 0; idx <= scores.Length - 1; idx++)
//        {
//            minrewards[idx] = 1;
//        }
//        for (int idx = 1; idx <= scores.Length - 1; idx++)
//        {
//            if (scores[idx] > scores[idx - 1])
//            {
//                minrewards[idx] = minrewards[idx - 1] + 1;
//            }
//        }
//        cntr = minrewards[scores.Length - 1];
//        for (int idx = scores.Length - 2; idx >= 0; idx--)
//        {
//            if (scores[idx] > scores[idx + 1] )
//            {
//                minrewards[idx] = Math.Max(minrewards[idx], minrewards[idx + 1] + 1);
//            }
//            cntr = cntr + minrewards[idx];
//        }

//        return cntr;
//    }

    
//}
