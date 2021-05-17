//using System;
//using System.Collections.Generic;

//public class Program
//{
//    // Tip: You can use `el is IList<object>` to check whether an item is a list or
//    // an integer.
//    public static int ProductSum(List<object> array)
//    {
//        // Write your code here.
//        return HelperProductSum(array, 1);
//    }

//    public static int HelperProductSum(List<object> array, int multi)
//    {
//        int sum = 0;
//        for(int idx = 0; idx < array.Count; idx++)
//        {
//            if (array[idx] is IList<object>)
//            {
//                sum = sum + HelperProductSum((List<object>)array[idx], multi + 1);
//            }
//            else
//            {
//                sum = sum + Convert.ToInt32(array[idx]);
//            }
//        }

//        return sum * multi;
//    }
//    static void Main(string[] args)
//    {
//        List<object> test = new List<object>(){
//            5,
//            2,
//            new List<object>(){
//                7, -1
//            },
//            3,
//            new List<object>(){
//                6,
//                new List<object>(){
//                    -13, 8
//                },
//                4,
//            },
//        };

//        Program.ProductSum(test);
//    }
//}


