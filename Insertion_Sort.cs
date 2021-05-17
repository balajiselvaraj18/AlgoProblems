//using System;

//public class Program
//{
//    public static int[] InsertionSort(int[] array)
//    {
//        // Write your code here.
//        if (array.Length > 1)
//            HelperInsertionSort(array, 1);

//        return array;
//    }

//    private static void HelperInsertionSort(int[] array, int loopIndx)
//    {
//        int temp = 0;
//        for (int indx = loopIndx; indx >= 0; indx--)
//        {
//            if ((indx - 1) >= 0)
//            {
//                if (array[indx] < array[indx - 1])
//                {
//                    temp = array[indx];
//                    array[indx] = array[indx - 1];
//                    array[indx - 1] = temp;
//                }
//            }
//        }
//        if ((array.Length - 1) != loopIndx)
//        {
//            HelperInsertionSort(array, ++loopIndx);
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] input = { 8, 5, 2, 9, 5, 6, 3 };
//        Program.InsertionSort(input);
//    }
//}
