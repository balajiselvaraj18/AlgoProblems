using System;
using System.Collections.Generic;

public class Program
{
    public static List<List<int>> Powerset(List<int> array)
    {
        // Write your code here.
        List<List<int>> FinalSet = new List<List<int>>();
        FinalSet.Add(new List<int>());
        foreach (int element in array)
        {
            int len = FinalSet.Count;
            for (int i = 0; i < len; i++)
            {
                List<int> currentSet = new List<int>(FinalSet[i]);
                currentSet.Add(element);
                FinalSet.Add(currentSet);
            }
        }

        return FinalSet;
    }

    static void Main()
    {
        Program.Powerset((new List<int>() { 1,2,3}));
    }
}
