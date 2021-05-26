//using System;


//public class Program
//{

//    public int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
//    {
//        // Write your code here.
//        Array.Sort(redShirtSpeeds);
//        Array.Sort(blueShirtSpeeds);
//        int returnval = 0;

//        if (fastest)
//        {
//            for (int i = 0; i < redShirtSpeeds.Length; i++)
//            {
//                returnval += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[redShirtSpeeds.Length - i - 1]);
//            }
//        }
//        else
//        {
//            for (int i = blueShirtSpeeds.Length - 1; i >= 0; i--)
//            {
//                returnval += Math.Max(blueShirtSpeeds[i], redShirtSpeeds[i]);
//            }
//        }

//        return returnval;
//    }

//    public static void Main()
//    {
//        int[] redShirtSpeeds = new int[] { 5, 5, 3, 9, 2 };
//        int[] blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };

//        Program pr = new Program();
//        pr.TandemBicycle(redShirtSpeeds, blueShirtSpeeds, false);
//    }
//}