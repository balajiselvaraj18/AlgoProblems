//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntPractProb
//{
//    class ArmStrongNumber_or_Not
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ArmStrong number is : " + IsArmStrongNumOrNot(120));
//            Console.ReadLine();
//        }
//        public static bool IsArmStrongNumOrNot(int val)
//        {
//            int sum = 0;
//            int PowerVal = val.ToString().Length;
//            int TempVal = val;
//            while (TempVal > 0)
//            {
//                int r = TempVal % 10;
//                sum = sum + power(r, PowerVal);
//                TempVal = TempVal / 10;
//            }

//            return sum == val;
//        }

//        static int power(int num, int powerVal)
//        {
//            int retVal = num;
//            if (num != 0)
//            {
//                for (int idx = 1; idx < powerVal; idx++)
//                {
//                    num = num * retVal;
//                }
//                return num;
//            }

//            return 0;
//        }
//    }

    

//}
