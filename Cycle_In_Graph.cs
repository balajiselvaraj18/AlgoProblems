//using System;


//public class Program
//{
//    int NOTVISITED = 0;
//    int VISITEDORINPROGESS = 1;
//    int COMPLETED = 2;
//    public bool CycleInGraph(int[][] edges)
//    {
//        // Write your code here.

//        int NodeLength = edges.Length;
//        int[] NodeArray = new int[NodeLength];

//        for (int idx = 0; idx < NodeLength; idx++)
//        {
//            if (NodeArray[idx]!= NOTVISITED) {
//                continue;
//            }

//            bool isCycleExists = IterateTheGraph(edges, idx, NodeArray);
//            if (isCycleExists)
//            {
//                return true;
//            }
//        }

//        return false;
//    }

//    public  bool IterateTheGraph(int[][] edges, int CurrentNodeIndx, int[] NodeArray)
//    {
//        NodeArray[CurrentNodeIndx] = VISITEDORINPROGESS;

//        int[] ValsToBeProcessedArray = edges[CurrentNodeIndx];

//        for (int adjacentIdx = 0; adjacentIdx < ValsToBeProcessedArray.Length; adjacentIdx++)
//        {
//            int AdjEdges = NodeArray[ValsToBeProcessedArray[adjacentIdx]];

//            if (AdjEdges == VISITEDORINPROGESS)
//            {
//                return true;
//            }

//            if (AdjEdges == COMPLETED)
//            {
//                continue;
//            }

//            bool isCycleExists = IterateTheGraph(edges, ValsToBeProcessedArray[adjacentIdx], NodeArray);
//            if (isCycleExists)
//                return true;
//        }
//        NodeArray[CurrentNodeIndx] = COMPLETED;
//        return false;
//    }


//    static void Main(string[] args)
//    {

//        int[][] input = new int[][] {
//            new int[] {1, 3},
//            new int[] {2, 3, 4},
//            new int[] {0},
//            new int[] {},
//            new int[] {2, 5},
//            new int[] {}
//        };

//        Program pro = new Program();
//        pro.CycleInGraph(input);
//    }
//}

