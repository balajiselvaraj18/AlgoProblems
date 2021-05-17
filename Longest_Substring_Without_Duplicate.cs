//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static string LongestSubstringWithoutDuplication(string str)
//    {
//        // Write your code here
//        int StartIndx = 0;
//        int[] longest_string = { 0, 1 };

//        Dictionary<char, int> checkDict = new Dictionary<char, int>();

//        for (int idx = 0; idx < str.Length; idx++)
//        {
//            char c = str[idx];

//            if (checkDict.ContainsKey(c))
//            {
//                StartIndx = Math.Max(StartIndx, checkDict[c] + 1);
//            }

//            if (longest_string[1] - longest_string[0] < idx + 1 - StartIndx)
//            {
//                longest_string = new int[] { StartIndx, idx + 1 };
//            }

//            checkDict[c] = idx;
//        }
//        string result = str.Substring(longest_string[0], longest_string[1] - longest_string[0]);
//        return result;
//    }

//    static void Main(String[] args)
//    {
//        Program.LongestSubstringWithoutDuplication("clementisacap");
//    }
//}