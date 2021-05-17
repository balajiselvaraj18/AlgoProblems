//using System;

//public class Program
//{
//    static void Main()
//    {
//        int[] input = { 0, 8, 0, 0, 5, 0, 0, 10, 0, 0, 1, 1, 0, 3 };
//        Program.WaterArea(input);
//    }
//    public static int WaterArea(int[] heights)
//    {
//        // Write your code here.
//        if (heights.Length == 0)
//            return -1;

        

//        int leftMaxHeightVal = heights[0];
//        int rightMaxHeightValue = 0;

//        int[] leftMax = new int[heights.Length - 1];
//        int[] rightMax = new int[heights.Length - 1];
//        int[] WaterArr = new int[heights.Length - 1];
//        int minval = 0;
//        int finalresult = 0;

 

//        for (int idx = 1; idx < heights.Length - 1; idx++)
//        {
//            if (heights[idx - 1] > leftMaxHeightVal)
//            {
//                leftMaxHeightVal = heights[idx - 1];
//            }
//            leftMax[idx] = leftMaxHeightVal;
//        }

//        for (int idx = heights.Length - 2; idx >= 0; idx--)
//        {
//            if (heights[idx + 1] > rightMaxHeightValue)
//            {
//                rightMaxHeightValue = heights[idx + 1];
//            }
//            rightMax[idx] = rightMaxHeightValue;
//        }

//        for (int idx = 0; idx < heights.Length - 1; idx++)
//        { 
//            minval = Math.Min(leftMax[idx], rightMax[idx]);

//            if (heights[idx] < minval)
//            {
//                finalresult = finalresult + (minval - heights[idx]);
//            }
//        }

//        return finalresult;
//    }


//}
