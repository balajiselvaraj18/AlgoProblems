//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static List<int> MoveElementToEnd(List<int> array, int toMove)
//    {
//        // Write your code here.
//        int dec = array.Count - 1;
//        int temp = 0;
//        for (int idx = 0; idx < array.Count; idx++)
//        {
//            if(idx < dec)
//            {
//                if(array[idx]!= toMove)
//                {
//                    //do nothing
//                }
//                else if (array[idx] == toMove && array[idx] == array[dec])
//                {
//                    --dec;
//                    --idx; 
//                }
//                else if (array[idx] == toMove && array[idx]!= array[dec])
//                {
//                    temp = array[idx];
//                    array[idx] = array[dec];
//                    array[dec] = temp;
//                    --dec;
//                }
//            }
//        }

//        return array;
//    }

//    static void Main(string[] args)
//    {
//        List<int> array = new List<int>(){2, 1, 2, 2, 2, 3, 4, 2};
//        Program.MoveElementToEnd(array, 2);
//    }
//}
