//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
//    {
//        // Write your code here.
//        Array.Sort(array);

//        List<int[]> ThreeNoSumArray = new List<int[]>();
//        int nextpos = 0;
//        int lastPos = 0;
//        if (array.Length > 0 && nextpos + 1 <= array.Length)
//        {
//            for (int id = 0; id < array.Length; id++)
//            {
//                lastPos = array.Length - 1;
//                for (int jd = id + 1; jd < lastPos; jd++)
//                {
//                    if (jd > lastPos) { break; }
//                    if (array[id] + array[jd] + array[lastPos] == targetSum && jd < lastPos)
//                    {
//                        int[] tempArray = { array[id], array[jd], array[lastPos] };
//                        ThreeNoSumArray.Add(tempArray);
//                    }
//                    else if (array[id] + array[jd] + array[lastPos] > targetSum && jd < lastPos)
//                    {
//                        --jd;
//                        --lastPos;
//                    }
//                }
//            }
//        }
//        return ThreeNoSumArray;

//    }

//    static void Main(string[] args)
//    {
//        Program.ThreeNumberSum(new int[] { 12, 3, 1, 2, -6, 5, 0, -8, -1, 6, -5 }, 0);
//    }
//}

