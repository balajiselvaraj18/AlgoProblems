using System;

public class Program
{
    public static int[] QuickSort(int[] array)
    {
        // Write your code here.
        HelperForQuickSort(array, 0, array.Length - 1);
        return array;
    }

    public static void HelperForQuickSort(int[] array, int startIndx, int endIndx)
    {
        if (startIndx >= endIndx)
        {
            return;
        }
        int pivot = startIndx;
        int leftIndx = startIndx + 1;
        int rightIndx = endIndx;

        while (rightIndx >= endIndx)
        {
            if (array[leftIndx] > array[pivot] && array[rightIndx] < array[pivot])
            {
                swap(array, leftIndx, rightIndx);
            }
            if (array[leftIndx] <= array[pivot])
            {
                leftIndx = leftIndx + 1;
            }
            if (array[rightIndx] >= array[pivot])
            {
                rightIndx = rightIndx - 1;
            }
        }
        swap(array, pivot, rightIndx);
       // bool leftSubtree = rightIndx - 1 - startIndx < endIndx - (rightIndx + 1);

        if((rightIndx - startIndx) - 1 < endIndx - (rightIndx + 1))
        {
            HelperForQuickSort(array, startIndx, rightIndx - 1);
            HelperForQuickSort(array, rightIndx + 1, endIndx);
        }
        else
        {
            HelperForQuickSort(array, rightIndx + 1, endIndx);
            HelperForQuickSort(array, startIndx, rightIndx - 1);
        }
    }

    public static void swap(int[] array, int leftIndx, int rightIndx)
    {
        int temp = array[rightIndx];
        array[rightIndx] = array[leftIndx];
        array[leftIndx] = temp;
    }

    static void Main(String[] args)
    {
        int[] input = { 8, 5, 2, 9, 5, 6, 3 };
        Program.QuickSort(input);
    }
}
