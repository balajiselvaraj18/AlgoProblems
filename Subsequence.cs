//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoPrep
//{
//    class Program
//    {
//        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
//        {
//            // Write your code here.
//            int val = 0;
//            int curr_pos = 0;
            
//            for (int indx = 0; indx < array.Count; indx++)
//            {
//                for (int sindx = curr_pos; sindx < sequence.Count; sindx++)
//                {
//                    if (array[indx] == sequence[sindx] && val < sequence.Count)
//                    {
//                        curr_pos++;
//                        val++;
//                        break;
//                    }
//                }
//            }

//            return val == sequence.Count;
//        }

//        static void Main(string[] args)
//        {
//            int no_Of_Values = Convert.ToInt32(Console.ReadLine());
//            int no_of_vals_Seq = Convert.ToInt32(Console.ReadLine());

//            List<int> array = new List<int>();
//            List<int> sequence = new List<int>();

//            //int Targetsum = Convert.ToInt32(Console.ReadLine());
//            int[] arr_values = new int[no_Of_Values];
//            int[] seq_values = new int[no_of_vals_Seq];

//            for (int indx = 0; indx < no_Of_Values; indx++)
//            {
//                int value = Convert.ToInt32(Console.ReadLine());
//                arr_values[indx] = value;
//            }

//            for (int indx = 0; indx < no_of_vals_Seq; indx++)
//            {
//                int value = Convert.ToInt32(Console.ReadLine());
//                seq_values[indx] = value;
//            }

//            array = arr_values.ToList();
//            sequence = seq_values.ToList();

//            IsValidSubsequence(array, sequence);
//        }
//    }
//}
