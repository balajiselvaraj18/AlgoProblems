//using System;


//public class Program
//{
//    public  string RunLengthEncoding(string str)
//    {
//        // Write your code here.
//        string Result = string.Empty;
//        char[] chararr = str.ToCharArray();
//        char charLetter = chararr[0];

//        int Counter = 0;

//        for (int indx = 0; indx < chararr.Length; indx++)
//        {
//            if(chararr[indx] == charLetter)
//            {
//                ++Counter;
//                if(Counter == 9)
//                {
//                    Result = Result + Counter + charLetter;
//                    Counter = 0;
//                }
//            }
//            else
//            {
//                if(Counter > 0)
//                {
//                    Result = Result + Counter + charLetter;
//                }
//                charLetter = chararr[indx];
//                Counter = 0;
//                ++Counter;
//            }
//        }

//        if(Counter > 0)
//        {
//            Result = Result + Counter + charLetter;
//        }

//        return Result;
//    }

//    private static Boolean CheckExists(char value, char[] carr)
//    {

//        return true;
//    }

//    static void Main(string[] args)
//    {
//        string input = "AAAAAAAAAAAAABBCCCCDD";
//        Program pr = new Program();
//        pr.RunLengthEncoding(input);
//    }
//}
