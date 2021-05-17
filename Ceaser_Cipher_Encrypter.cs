//using System;

//public class Program
//{
//    public static string CaesarCypherEncryptor(string str, int key)
//    {
//        // Write your code here.
//        int ascii = 0;
//        string finalstring = string.Empty;
//        if(key > 26)
//        {
//            key = key % 26;
//        }
//        foreach (char s in str)
//        {
//            ascii = (int)s + key;
//            if(ascii >= 97 && ascii <= 122)
//            {
//                finalstring = finalstring + Convert.ToString((Char)ascii);
//            }
//            else
//            {
//                ascii = ascii - 26;
//                finalstring = finalstring + Convert.ToString((Char)ascii);
//            }
//        }

//        return finalstring;
//    }

//    static void Main(string[] args)
//    {
//        Program.CaesarCypherEncryptor("abc", 57);
//    }
//}
