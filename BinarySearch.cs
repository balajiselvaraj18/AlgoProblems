//using System;

//public class Program
//{
//    public static int BinarySearch(int[] array, int target)
//    {
//        // Write your code here.
//        return HelperBinarySearch(0, array.Length - 1, 0, array, target);
//    }
//    public static int HelperBinarySearch(int left, int right, int Middle, int[] arr, int target)
//    {
//        int Mid = (left + right) / 2;
       

//        if(left > right) { return -1; }

//        if(arr[Mid]!= 33 && arr[Mid] > target)
//        {
//            right = Mid - 1;
//            return HelperBinarySearch(left, right, Mid, arr, target);

//        }
//        else if(arr[Mid]!= 33 && arr[Mid] < target)
//        {
//            left = Mid + 1;
//            return HelperBinarySearch(left, right, Mid, arr, target);
//        }
//        else if(arr[Mid] == target)
//        {
//            return Mid;
//        }
//        return 0;
        
//    }
//    static void Main(string[] args)
//    {
//        Program.BinarySearch(new int[] {0, 1, 21, 33, 45, 45, 61, 71, 72,
//                                                         73}, 33);
//    }
//}
