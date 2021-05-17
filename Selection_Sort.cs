//using System;

//public class Program
//{
//    public static int[] SelectionSort(int[] array)
//    {
//        // Write your code here.
//        return HelperSelectionSort(0,  array);
//    }

//    private static int[] HelperSelectionSort(int int_Pos, int[] array)
//    {
//        int intPos = int_Pos;
//        int smallpos = int_Pos;
//        int indePos = intPos;

//        if(intPos + 1 <= (array.Length -1))
//        {
//            for (int indx = intPos; indx < array.Length; indx++)
//            {
//                if (indx + 1 <= (array.Length - 1))
//                {
//                    if ((array[smallpos] > array[indx + 1]))
//                    {
//                        smallpos = indx + 1;
//                    }
//                }
//            }
//        }

//        if (indePos == array.Length - 1)
//        {
//            return array;
//        }
//        else
//        {
//            swap(array, indePos, smallpos);

//            HelperSelectionSort(++indePos, array);
//        }
//        return array;
//    }

//    private static void swap(int [] array, int indxpos, int smallpos)
//    {
//        int tmp = array[indxpos];
//        array[indxpos] = array[smallpos];
//        array[smallpos] = tmp;
//    }

//    static void Main(string[] args)
//    {
//        int[] input = { 8, 5, 2, 9, 5, 6, 3 };
//        Program.SelectionSort(input);
//    }
//}