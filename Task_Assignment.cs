//using System.Collections.Generic;
//using System;

//public class Program
//{

//    public List<List<int>> TaskAssignment(int k, List<int> tasks)
//    {
//        // Write your code here.

//        IDictionary<int, List<int>> KeyPairs = AssignedValuesToDictionary(tasks);
//        List<int> sortedList = tasks;
//        sortedList.Sort();
//        List<List<int>> TaskAssignmentLists = new List<List<int>>();

//        for (int index = 0; index < k; index++)
//        {
//            int duration1 = sortedList[index];

//            List<int> Pair1 = KeyPairs[duration1];

//            int ItemIndex1 = Pair1[Pair1.Count - 1];
//            Pair1.RemoveAt(Pair1.Count - 1);

//            int item2Index = tasks.Count - 1 - index;
//            int duration2 = sortedList[item2Index];

//            List<int> Pair2 = KeyPairs[duration2];

//            int ItemIndex2 = Pair2[Pair2.Count - 1];
//            Pair2.RemoveAt(Pair2.Count - 1);

//            List<int> TaskAssignmentList = new List<int>();
//            TaskAssignmentList.Add(ItemIndex1);
//            TaskAssignmentList.Add(ItemIndex2);
//            TaskAssignmentLists.Add(TaskAssignmentList);
//        }


//        return TaskAssignmentLists;
//    }

//    public IDictionary<int, List<int>> AssignedValuesToDictionary(List<int> tasks)
//    {
//        IDictionary<int, List<int>> DictionaryValues = new Dictionary<int, List<int>>();
//        int valToAdd = 0;

//        for (int indx = 0; indx < tasks.Count; indx++)
//        {
//            valToAdd = tasks[indx];
//            if (DictionaryValues.ContainsKey(valToAdd))
//            {
//                DictionaryValues[valToAdd].Add(indx);
//            }
//            else
//            {
//                List<int> temp = new List<int>();
//                temp.Add(indx);
//                DictionaryValues[valToAdd] = temp;
//            }

//        }
//        return DictionaryValues;
//    }

//    static void Main(string[] args)
//    {
//        var k = 3;
//        var tasks = new List<int> {
//            1, 3, 5, 3, 1, 4
//        };

//        Program pr = new Program();
//        pr.TaskAssignment(k, tasks);

//    }
//}
