//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntPractProb
//{
//    class Boolean_Matrix_Manipulation
//    {
//        static void Main(string[] args)
//        {
//            int[,] mat = {{1, 0, 0, 1},
//                      {0, 0, 1, 0},
//                      {0, 0, 0, 0}};

//            BoolMatrix(mat);
//        }

//        static void BoolMatrix(int[,] arr)
//        {
//            for (int row = 0; row < arr.GetLength(0); row++)
//            {
//                for (int col = 0; col < arr.GetLength(1); col++)
//                {
//                    if (arr[row, col] == 1)
//                    {
//                        manipulateMatrix(arr, 0, col, arr.GetLength(0), arr.GetLength(1));

//                    }
//                }
//            }
//        }


//        static void manipulateMatrix(int[,] matrix, int row, int col, int rowLen, int colLen)
//        {
//            for (int r = row; r < rowLen; r++)
//            {
//                matrix[r, col] = 1;
//            }

//            for (int c = col; c<colLen;c++)
//            {
//                matrix[row, c] = 1;
//            }
//        }

//    }
//}
