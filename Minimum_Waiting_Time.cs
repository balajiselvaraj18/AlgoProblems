//using System;


//public class Program
//{

//    public int MinimumWaitingTime(int[] queries)
//    {
//        // Write your code here.
//        Array.Sort(queries);
//        int Cnt = 0;
//        int FCnt = 0;

//        if (queries.Length == 1)
//        {
//            return 0;
//        }
//        else if (queries.Length == 2)
//        {
//            return queries[0];
//        }
//        else
//        {
//            Cnt = queries[0];
//            FCnt = queries[0];

//            for (int i = 1; i < queries.Length - 1; i++)
//            {
//                Cnt = Cnt + queries[i];
//                FCnt = FCnt + Cnt;
//            }
//        }
//        return FCnt;


//    }

//    static void Main()
//    {
//        Program pr = new Program();
//        pr.MinimumWaitingTime(new int[] { 3, 2, 1, 2, 6 });
//    }
//}

