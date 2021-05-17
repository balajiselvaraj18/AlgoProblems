//using System;
//using System.Collections;
//using System.Collections.Generic;

//public class Program
//{

//    public int[][] RemoveIslands(int[][] matrix)
//    {
//        // Write your code here.
//        bool[,] MarkTheNodeVals = new bool[matrix.Length, matrix[0].Length];

//        for (int i = 0; i < matrix.Length; i++)
//        {
//            MarkTheNodeVals[i, matrix[0].Length - 1] = false;
//        }

//        for (int rindx = 0; rindx < matrix.Length; rindx++)
//        {
//            for (int cIndx = 0; cIndx < matrix[rindx].Length; cIndx++)
//            {
//                bool rowIsBorder = rindx == 0 || rindx == matrix.Length - 1;
//                bool colIsBorder = cIndx == 0 || cIndx == matrix[rindx].Length - 1;
//                bool isBorderElement = rowIsBorder || colIsBorder;

//                if (!isBorderElement)
//                {
//                    continue;
//                }

//                if (matrix[rindx][cIndx] != 1)
//                {
//                    continue;
//                }
//                FindtheConnectedBorder(matrix, rindx, cIndx, MarkTheNodeVals);
//            }
//        }

//        for (int row = 1; row < matrix.Length - 1; row++)
//        {
//            for (int col = 1; col < matrix[row].Length - 1; col++)
//            {
//                if (MarkTheNodeVals[row, col])
//                {
//                    continue;
//                }
//                matrix[row][col] = 0;
//            }
//        }

//        return matrix;
//    }

//    public void FindtheConnectedBorder(int[][] matrix, int row, int col, bool[,] MarkTheNodeVals)
//    {

//        Stack<Tuple<int, int>> repos = new Stack<Tuple<int, int>>();
//        repos.Push(new Tuple<int, int>(row, col));
//        while (repos.Count > 0)
//        {
//            var stackData = repos.Pop();
//            int rowval = stackData.Item1;
//            int colval = stackData.Item2;

//            bool isVisited = MarkTheNodeVals[rowval, colval];

//            if (isVisited)
//                continue;


//            MarkTheNodeVals[rowval, colval] = true;

//            var lstVals = getAdjacentNodes(matrix, rowval, colval);

//            foreach (var valPairs in lstVals)
//            {
//                if (matrix[valPairs.Item1][valPairs.Item2] != 1)
//                {
//                    continue;
//                }

//                repos.Push(valPairs);
//            }
//        }
//    }

//    public List<Tuple<int, int>> getAdjacentNodes(int[][] matrix, int row, int col)
//    {
//        List<Tuple<int, int>> lstAdjacentNodes = new List<Tuple<int, int>>();

//        if (row - 1 >= 0)
//        {
//            lstAdjacentNodes.Add(new Tuple<int, int>(row - 1, col));
//        }

//        if (row + 1 <= matrix.Length - 1)
//        {
//            lstAdjacentNodes.Add(new Tuple<int, int>(row + 1, col));
//        }

//        if (col - 1 >= 0)
//        {
//            lstAdjacentNodes.Add(new Tuple<int, int>(row, col - 1));
//        }

//        if (col + 1 <= matrix[row].Length - 1)
//        {
//            lstAdjacentNodes.Add(new Tuple<int, int>(row, col + 1));
//        }

//        return lstAdjacentNodes;


//    }

//    static void Main(string[] args)
//    {
//        int[][] input = new int[][] {
//            new int[] {1, 0, 0, 0, 0, 0},
//            new int[] {0, 1, 0, 1, 1, 1},
//            new int[] {0, 0, 1, 0, 1, 0},
//            new int[] {1, 1, 0, 0, 1, 0},
//            new int[] {1, 0, 1, 1, 0, 0},
//            new int[] {1, 0, 0, 0, 0, 1},
//        };

//        Program p = new Program();


//        p.RemoveIslands(input);
//    }
//}

