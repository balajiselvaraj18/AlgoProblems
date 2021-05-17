//using System.Collections.Generic;
//using System;

//public class Program
//{

//    public int FirstDuplicateValue(int[] array)
//    {
//        // Write your code here.
//        HashSet<int> hashVal = new HashSet<int>();
//        foreach (var val in array)
//        {
//            if (hashVal.Contains(val))
//            {
//                return val;
//            }
//            else
//            {
//                hashVal.Add(val);
//            }
//        }
        
//        return -1;
//    }
//    static void Main(string[] args)
//    {
//        var input = new int[] { 2, 1, 5, 2, 3, 3, 4 };
//        Program pr = new Program();
//        pr.FirstDuplicateValue(input);
//    }
//}