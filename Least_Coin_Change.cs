//using System;


//public class Program
//{

//    public int NonConstructibleChange(int[] coins)
//    {
//        // Write your code here.
//        Array.Sort(coins);
//        int CurrentChange = 0;
//        foreach (var coin in coins)
//        {
//            if(coin > CurrentChange + 1)
//            {
//                return CurrentChange + 1;
//            }

//            CurrentChange = CurrentChange + coin;
//        }


//        return CurrentChange;
//    }

//    static void Main()
//    {
//        Program pr = new Program();
//        pr.NonConstructibleChange(new int[] { 5, 7, 1, 1, 2, 3, 22 });
//    }
//}

