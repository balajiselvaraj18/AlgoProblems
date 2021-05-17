//using System;

//public class Progam
//{
//    public static int LevenshteinDistance(string str1, string str2)
//    {
//        // Write your code here. 

//        int[,] edits = new int[str2.Length + 1, str1.Length + 1];

//        for (int row = 0; row < str2.Length + 1; row++)
//        {
//            for (int col = 0; col < str1.Length; col++)
//            {
//                edits[row, col] = col;
//            }
//            edits[row, 0] = row;
//        }

//        for (int row = 1; row < str2.Length + 1; row++)
//        {
//            for (int column = 1; column < str1.Length + 1; column++)
//            {
//                if (str2[row - 1] == str1[column - 1])
//                {
//                    edits[row, column] = edits[row - 1, column - 1];
//                }
//                else
//                {
//                    edits[row, column] = Math.Min(Math.Min(edits[row - 1, column - 1], edits[row, column - 1]), edits[row - 1, column]) + 1;
//                }
//            }
//        }

//        return edits[str2.Length, str1.Length];


//    }

//    static void Main(string[] args)
//    {
//        Progam.LevenshteinDistance("abc", "yabd");
//    }

//}
