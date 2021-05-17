//using System;

//public class Program
//{
//    public static bool HasSingleCycle(int[] array)
//    {
//        // Write your code here.

      

//        int NoOfElementsVisited = 0;
//        int CurrentIndx = 0;

//        while (NoOfElementsVisited < array.Length)
//        {
//            if (NoOfElementsVisited < array.Length)
//            {
//                return false;
//            }
//            NoOfElementsVisited++;
//            CurrentIndx = getindx(CurrentIndx, array);
//        }

//        return CurrentIndx == 0;
//    }

//    public static int getindx(int currIndx, int[] array)
//    {
//        int postionIndx = array[currIndx];
//        int nextElementIndx = (postionIndx + currIndx) % array.Length;
//        return nextElementIndx >= 0 ? nextElementIndx : nextElementIndx + array.Length;
//    }
//    //
//    static void Main(string[] args)
//    {
//        Program.HasSingleCycle(new int[] { -1, 2, 2 });
//    }
//}