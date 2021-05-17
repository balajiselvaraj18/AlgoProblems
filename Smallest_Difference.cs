//using System;

//public class Program
//{
//    public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
//    {
//        // Write your code here.
//        int current = int.MaxValue;
//        int small = int.MaxValue;
//        int oneIndx = 0;
//        int twoIndx = 0;
//        Array.Sort(arrayOne);
//        Array.Sort(arrayTwo);
//        int[] result = new int[2];

//        while (oneIndx < arrayOne.Length && twoIndx < arrayTwo.Length)
//        {
//            int Firstnum = arrayOne[oneIndx];
//            int SecondNum = arrayTwo[twoIndx];
//            if (arrayOne[oneIndx] < arrayTwo[twoIndx])
//            {
//                current = SecondNum - Firstnum;
//                oneIndx++;
//            }
//            else if (arrayOne[oneIndx] > arrayTwo[twoIndx])
//            {
//                current = Firstnum - SecondNum;
//                twoIndx++;
//            }
//            else
//            {
//                return result = new int[] { Firstnum, SecondNum };
//            }

//            if (small > current)
//            {
//                small = (Firstnum - SecondNum) < 0 ? ((Firstnum - SecondNum) * (-1)) : (Firstnum - SecondNum);
//                result = new int[] { Firstnum, SecondNum };
//            }
//        }

//        return result;
//    }
//    static void Main(string[] args)
//    {
//        int[] arrayOne = { -1, 5, 10, 20, 28, 3 };
//        int[] arrayTwo = { 26, 134, 135, 15, 17 };

//        Program.SmallestDifference(arrayOne, arrayTwo);
//    }
////}
