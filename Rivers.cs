//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static List<int> RiverSizes(int[,] matrix)
//    {
//        // Write your code here.
//        List<int> size = new List<int>();
//        bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                if (visited[i, j])
//                {
//                    continue;
//                }
//                else
//                {
//                    traverseNode(i, j, matrix, visited, size);
//                }
//            }
//        }

//        return new List<int>();
//    }

//    public static void traverseNode(int i, int j, int[,] matrix, bool[,] visited, List<int> sizes)
//    {
//        int cntr = 0;
//        Stack<int[]> rowCol = new Stack<int[]>();
//        rowCol.Push(new int[] { i, j });
//        while (rowCol.Count > 0)
//        {
//            int[] currCordinates = rowCol.Pop();
//            i = currCordinates[0];
//            j = currCordinates[1];

//            if (visited[i, j])
//            {
//                continue;
//            }
//            visited[i, j] = true;
//            if (matrix[i, j] == 0)
//            {
//                continue;
//            }
//            cntr++;
//            List<int[]> adjuscentRiverVals = getadjacentEdgesOfNotVisited(i, j, matrix, visited);

//            foreach (var adjacentVals in adjuscentRiverVals)
//            {
//                rowCol.Push(adjacentVals);
//            }
//        }

//        if (cntr > 0)
//        {
//            sizes.Add(cntr);
//        }
//    }

//    public static List<int[]> getadjacentEdgesOfNotVisited(int i, int j, int[,] matrix, bool[,] visited)
//    {
//        List<int[]> ValidAdjuscentvals = new List<int[]>();

//        if (i > 0 && visited[i - 1, j] == false)
//        {
//            ValidAdjuscentvals.Add(new int[] { i - 1, j });
//        }

//        if (i < matrix.GetLength(0) && visited[i + 1, j] == false)
//        {
//            ValidAdjuscentvals.Add(new int[] { i + 1, j });
//        }

//        if (j > 0 && visited[i, j - 1] == false)
//        {
//            ValidAdjuscentvals.Add(new int[] { i, j - 1 });
//        }

//        if (j < matrix.GetLength(1) && visited[i, j + 1] == false)
//        {
//            ValidAdjuscentvals.Add(new int[] { i, j + 1 });
//        }
//        return ValidAdjuscentvals;
//    }



//    static void Main(string[] args)
//    {
//        int[,] input = {
//            {1, 0, 0, 1, 0},
//            {1, 0, 1, 0, 0},
//            {0, 0, 1, 0, 1},
//            {1, 0, 1, 0, 1},
//            {1, 0, 1, 1, 0},
//        };

//        Program.RiverSizes(input);
//    }
//}