//using System;
//using System.Collections.Generic;


//public class Program
//{
//    public bool GenerateDocument(string characters, string document)
//    {
//        // Write your code here.

//        char[] charArr = characters.ToCharArray();
//        int cntr;
//        Dictionary<char, int> dictValues = new Dictionary<char, int>();

//        for (int i = 0; i < charArr.Length; i++)
//        {
//            cntr = 0;
//            if (!dictValues.ContainsKey(charArr[i]))
//            {
//                dictValues.Add(charArr[i], 1);
//            }
//            else
//            {
//                cntr = dictValues[charArr[i]] + 1;
//                dictValues[charArr[i]] = cntr;
//            }
//        }

//        charArr = document.ToCharArray();

//        for (int j = 0; j < charArr.Length; j++)
//        {
//            cntr = 0;
//            if (dictValues.ContainsKey(charArr[j]))
//            {
//                cntr = dictValues[charArr[j]] - 1;
//                dictValues[charArr[j]] = cntr;
//                if(dictValues[charArr[j]] == 0)
//                {
//                    dictValues.Remove(charArr[j]);
//                }
//            }
//            else
//            {
//                return false;
//            }
//        }

//        return true ;
//    }
//    static void Main()
//    {
//        Program pr = new Program();
//        string characters = "Bste!hetsi ogEAxpelrt x ";
//        string document = "AlgoExpert is the Best!";
//        pr.GenerateDocument(characters, document);
//    }
//}

