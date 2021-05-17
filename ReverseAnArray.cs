//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntPractProb
//{
//    class ReverseAnArray
//    {
//        static void Main(string[] args)
//        {
//            int[] arrayEle = { 1, 2, 3, 4, 5, 6, 7 };
//            PrintEle(ReverseTheArray(arrayEle));
//        }
//        static int[] ReverseTheArray(int[] arr)
//        {
//            int start = 0;
//            int end = arr.Length -1;
//            int temp = 0;

//            while (start < end)
//            {
//                temp = arr[start];
//                arr[start] = arr[end];
//                arr[end] = temp;
//                start++;
//                end--;
//            }
//            return arr;
//        }

//        static void PrintEle(int[] arr)
//        {
//            for (int idx = 0; idx < arr.Length; idx++)
//            {
//                Console.WriteLine(arr[idx]);
//            }
//            Console.ReadLine();
//        }
//    }
//}
