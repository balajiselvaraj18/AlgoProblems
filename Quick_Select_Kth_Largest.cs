//using System;

//public class Program
//{
//    public static int Quickselect(int[] array, int k)
//    {
//        // Write your code here.
//        int position = k - 1;
//        return helperForQuickKthSmallestElement(0, array.Length -1, array, position);
//    }

//    private static int helperForQuickKthSmallestElement(int startIndx, int endIndx, int[] array, int position)
//    {
//        if (startIndx > endIndx)
//        {
//            throw new Exception("Start cannot be greater than End");
//        }

//        while (true)
//        {
//            int pivot = startIndx;
//            int leftIndx = startIndx + 1;
//            int rightIndx = array.Length - 1;

//            while (startIndx <= endIndx)
//            {
//                if (array[leftIndx] > array[pivot] && array[rightIndx] < array[pivot])
//                {
//                    swap(leftIndx, rightIndx, array);
//                }

//                if (array[leftIndx] <= array[pivot])
//                {
//                    leftIndx++;
//                }

//                if (array[rightIndx] >= array[pivot])
//                {
//                    rightIndx--;
//                }
//            }


//            swap(pivot, rightIndx, array);

//            if(rightIndx == position)
//            {
//                return array[rightIndx];
//            }

//            else if (array[rightIndx] < position)
//            {
//                startIndx = rightIndx + 1;
//            }
//            else
//            {
//                endIndx = rightIndx - 1;
//            }

//        }
//    }

//    private static void swap(int leftIndx, int rightIndx, int[] array)
//    {
//        int temp = array[leftIndx];
//        array[leftIndx] = array[rightIndx];
//        array[rightIndx] = temp;
//    }

   
//}
