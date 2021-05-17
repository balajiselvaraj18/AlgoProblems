//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntPractProb
//{
//    class SieveOfErastothenes
//    {
//        static void Main(string[] args)
//        {
//            PrintThePrimeNos(30);
//        }

//        static void PrintThePrimeNos(int no)
//        {
//            bool[] chkNosPrimeorNot = new bool[no + 1];

//            for (int idx = 2; idx <= no; idx++)
//            {
//                if (!chkNosPrimeorNot[idx])
//                {
//                    for (int jdx = idx * idx; jdx <= no; jdx = jdx + idx)
//                    {
//                        chkNosPrimeorNot[jdx] = true;
//                    }
//                }
//            }

//        }
//    }
//}
