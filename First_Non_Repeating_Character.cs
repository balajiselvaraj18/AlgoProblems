//using System;
//using System.Collections.Generic;


//public class Program
//{

//    public int FirstNonRepeatingCharacter(string str)
//    {
//        // Write your code here.
//        Dictionary<char, Tuple<bool, int>> dictVals = new Dictionary<char, Tuple<bool, int>>();
//        char[] chtr = str.ToCharArray();
//        int FirstNonRepaIdx = Int32.MaxValue;
       
//        for (int i = 0; i < chtr.Length; i++)
//        {
            
//            if (!dictVals.ContainsKey(chtr[i]))
//            {
//                dictVals.Add(chtr[i], Tuple.Create(false, i));
//            }
//            else
//            {
//                dictVals[chtr[i]] = Tuple.Create(true, i);
//            }
//        }

//        foreach (var vals in dictVals)
//        {
//            if(vals.Value.Item1 == false)
//            {
//                FirstNonRepaIdx = Math.Min(FirstNonRepaIdx, vals.Value.Item2);
//            }

//        }

//        return FirstNonRepaIdx == Int32.MaxValue ? -1 : FirstNonRepaIdx;
//    }

//    static void Main()
//    {
//        string input = "abcdcaf";
//        Program pr = new Program();
//        pr.FirstNonRepeatingCharacter(input);
//    }
//}
