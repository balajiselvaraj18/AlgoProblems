//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoPrep
//{
//    class Program
//    {
//        public static int[] TwoNumberSum(int[] array, int targetSum)
//        {
//            int[] retArr = new int[2];
//            Write your code here.
//            for (int flp = 0; flp < array.Length; flp++)
//            {
//                for (int slp = 1; slp < array.Length; slp++)
//                {
//                    if (array[flp] + array[slp] == targetSum)
//                    {
//                        return new int[] { array[flp], array[slp] };
//                    }
//                }
//            }
//            return retArr;
//        }

//        static void Main(string[] args)
//        {
//            int no_Of_Values = Convert.ToInt32(Console.ReadLine());
//            int Targetsum = Convert.ToInt32(Console.ReadLine());
//            int[] arr_values = new int[no_Of_Values];
//            for (int indx = 0; indx < no_Of_Values; indx++)
//            {
//                int value = Convert.ToInt32(Console.ReadLine());
//                arr_values[indx] = value;
//            }
//            TwoNumberSum(arr_values, Targetsum);
//        }
//    }

//}
