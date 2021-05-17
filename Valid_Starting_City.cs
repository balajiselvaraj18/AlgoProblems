//using System;


//public class Program
//{

//    public int ValidStartingCity(int[] distances, int[] fuel, int mpg)
//    {
//        // Write your code here.
//        /* The problem is to find the Valid starting city index. 
//         here I used the Cntr variable to determine that it has done one full cycle. If Cntr == 5 then full cycle completed
//         */
//        int Cntr = 0;
//        int DistanceCovered = 0;
//        int idx = 0;
//        int length = distances.Length;

//        while (idx < length)
//        {
//            DistanceCovered = (DistanceCovered + fuel[idx] * mpg) - distances[idx];

//            // the values are set to 0 because the cycle which is in progress is failed so a new cycle has to be formed and so the values are reset to 0
//            if (DistanceCovered < 0)
//            {
//                DistanceCovered = 0;
//                Cntr = 0;
//                idx++;
//                continue;
//            }
//            Cntr++;

//            if (Cntr == distances.Length && DistanceCovered >= 0)
//            {
//                if (idx + 1 == distances.Length) // this is to determine whether it is zero index forms a cycle
//                {
//                    return 0;
//                }
//                else // if any other index forms a cycle then we go to this else. 
//                {
//                    return idx + 1;
//                }
//            }

//            if (idx + 1 == distances.Length && Cntr != distances.Length)// if the index starts at apart from zero then we need to reset the idx and length.
//                // ex. idx = 4 in loop and 4 is the last element then we need to start from zero so this logic is written.
//                // 0->1->2->3->4. if the idx starts at 4 then it has go on one cycle so this logic.
//            {
//                idx = 0;
//                length = length - Cntr;
//            }
//            else
//            {
//                idx++;
//            }
            
//        }

//        return -1;
//    }
//    static void Main(string[] args)
//    {

//        int[] distances = new int[] { 5, 25, 15, 10, 15 };
//        int[] fuel = new int[] { 1, 2, 1, 0, 3 };

//        Program pr = new Program();
//        pr.ValidStartingCity(distances, fuel, 10);
//    }

//}

