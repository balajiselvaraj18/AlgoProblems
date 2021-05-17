//using System;


//public class Program
//{
//    public int[] ArrayOfProducts(int[] array)
//    {
//        // Write your code here.
//        int lrp = 1;
//        int[] prodArra = new int[array.Length];
//        for (int indx = 0; indx < array.Length - 1; indx++)
//        {
//            prodArra[indx] = lrp;
//            lrp = lrp * array[indx];
//            prodArra[indx + 1] = lrp;
//        }

//        lrp = 1;

//        for (int indx = array.Length -1; indx >= 1; indx--)
//        {
//            lrp = lrp * array[indx];
//            prodArra[indx - 1] = lrp * prodArra[indx - 1];
//        }
//        return prodArra;
//    }
//    static void Main(string[] args)
//    {
//        var input = new int[] { 5, 1, 4, 2 };
//        Program pr = new Program();
//        pr.ArrayOfProducts(input);
//    }
//}
