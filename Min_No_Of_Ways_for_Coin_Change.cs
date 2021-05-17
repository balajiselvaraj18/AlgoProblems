//using System;

//public class Program
//{
//    public static int MinNumberOfCoinsForChange(int n, int[] denoms)
//    {
//        // Write your code here.
//        int Change_Denom = 0;
//        int Amount = 0;


//        int[] minChangeArray = new int[n + 1];

//        for (int aindx = 0; aindx < minChangeArray.Length; aindx++)
//        {
//            minChangeArray[aindx] = Int32.MaxValue;
//        }
//        minChangeArray[0] = 0;

//        for (int idx = 0; idx < denoms.Length; idx++)
//        {
//            Change_Denom = denoms[idx];
//            for (int aindx = 0; aindx < minChangeArray.Length; aindx++)
//            {
//                if (Change_Denom <= aindx)
//                {
//                    if (minChangeArray[aindx - Change_Denom] == Int32.MaxValue)
//                    {
//                        Amount = minChangeArray[aindx - Change_Denom];
//                    }
//                    else
//                    {
//                        Amount = minChangeArray[aindx - Change_Denom] + 1;
//                    }

//                    minChangeArray[aindx] = Math.Min(minChangeArray[aindx], Amount);
//                }
//            }
//        }
//        return minChangeArray[n] != Int32.MaxValue ? minChangeArray[n] : -1;
//    }
//    static void Main(string[] args)
//    {
//        int[] input = { 2, 4 };
//        Program.MinNumberOfCoinsForChange(7, input);
//    }
//}
