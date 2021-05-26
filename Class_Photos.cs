//using System.Collections.Generic;
//using System;
//public class Program
//{
//    public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
//    {
//        // Write your code here.
//        redShirtHeights.Sort();
//        blueShirtHeights.Sort();

//        bool isRedInFirstRow = (redShirtHeights[redShirtHeights.Count - 1] < blueShirtHeights[blueShirtHeights.Count - 1]) ? true : false;

//        for (int idx = redShirtHeights.Count - 1; idx >= 0; idx--)
//        {
//            int RedShirtValue = redShirtHeights[idx];
//            int BlueShirtValue = blueShirtHeights[idx];

//            if (isRedInFirstRow)
//            {
//                if (RedShirtValue >= BlueShirtValue)
//                    return false;
//            }
//            else
//            {
//                if (BlueShirtValue >= RedShirtValue)
//                    return false;
//            }
//        }
//        return true;
//    }
//    static void Main()
//    {
//        List<int> redShirtHeights = new List<int> {
//            5, 8, 1, 3, 4
//        };
//        List<int> blueShirtHeights = new List<int> {
//            6, 9, 2, 4, 5
//        };

//        Program PR = new Program();
//        PR.ClassPhotos(redShirtHeights, blueShirtHeights);
//    }
//}

