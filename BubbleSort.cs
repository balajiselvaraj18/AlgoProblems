//using System;

//public class Program
//{
//    public static int[] BubbleSort(int[] array)
//    {
//        // Write your code here.
//        HelperForBubbleSort(array, array.Length - 1);

//        return array;
//    }

//    private static void HelperForBubbleSort(int[] array, int Arraylength)
//    {
//        int temp = 0;
//        for (int indx = 0; indx < Arraylength; indx++)
//        {
//            if (!(indx >= (array.Length - 1)))
//            {
//                if (array[indx] > array[indx + 1])
//                {
//                    temp = array[indx];
//                    array[indx] = array[indx + 1];
//                    array[indx + 1] = temp;
//                }
//            }
//        }

//        if (Arraylength != 0)
//            HelperForBubbleSort(array, --Arraylength);
        
//    }
//    static void Main(string[] args)
//    {
//        int[] input = { 8, 5, 2, 9, 5, 6, 3 };
//        Program.BubbleSort(input);
//    }
//}