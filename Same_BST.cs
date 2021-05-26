//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static bool SameBsts(List<int> arrayOne, List<int> arrayTwo)
//    {
//        // Write your code here.
//        if (arrayOne.Count != arrayTwo.Count) return false;

//        if (arrayOne.Count == 0 && arrayTwo.Count == 0) return true;

//        if (arrayOne[0] != arrayTwo[0]) return false;

//        List<int> smallOne = getSmallarVals(arrayOne);
//        List<int> smallTwo = getSmallarVals(arrayTwo);
//        List<int> bigOne = getSmallarVals(arrayOne);
//        List<int> bigTwo = getSmallarVals(arrayTwo);
//        return SameBsts(smallOne, smallTwo) && SameBsts(bigOne, bigTwo);
//    }

//    private static List<int> getSmallarVals(List<int> array)
//    {
//        List<int> returnLst = new List<int>();
//        for (int i = 0; i < array.Count - 1; i++)
//        {
//            if(array[i] < array[0])
//            {
//                returnLst.Add(array[i]);
//            }
//        }
//        return returnLst;
//    }

//    private static List<int> getBiggerVals(List<int> array)
//    {
//        List<int> returnLst = new List<int>();
//        for (int i = 0; i < array.Count - 1; i++)
//        {
//            if (array[i] >= array[0])
//            {
//                returnLst.Add(array[i]);
//            }
//        }
//        return returnLst;
//    }
//}
