//using System;

//public class Program
//{
//    public static bool IsMonotonic(int[] array)
//    {
//        // Write your code here.
//        string direction = "eq";

//        if (array.Length == 1 || array.Length == 0)
//        {
//            return true;
//        }

//        for (int idx = 0; idx < array.Length; idx++)
//        {
//            if (idx + 1 <= array.Length - 1)
//            {
//                if (direction == "eq")
//                {
//                    if (array[idx] < array[idx + 1])
//                    {
//                        direction = "inc";
//                    }
//                    else if (array[idx] > array[idx + 1])
//                    {
//                        direction = "dec";
//                    }
//                }
//                else if (direction == "inc" && array[idx] > array[idx + 1])
//                {
//                    return false;
//                }
//                else if (direction == "dec" && array[idx] < array[idx + 1])
//                {
//                    return false;
//                }
//            }
//        }

//        return true;
//    }

//    static void Main(string[] args)
//    {
//        var array = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
//        Program.IsMonotonic(array);
//    }
//}