using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        long[] arr_Manipltn;
        long a, b, k;
        long largest_value = 0;
        long row_length = queries.Length;
        try
        {
            arr_Manipltn = new long[n + 1];

            for (long indx = 0; indx < row_length; indx++)
            {
                a = Convert.ToInt32(queries[indx][0]);
                b = Convert.ToInt32(queries[indx][1]);
                k = Convert.ToInt32(queries[indx][2]);

                for (long id_qu = a; id_qu <= b; id_qu++)
                {
                    arr_Manipltn[id_qu] = arr_Manipltn[id_qu] + k;
                    if (arr_Manipltn[id_qu] > largest_value)
                    {
                        largest_value = arr_Manipltn[id_qu];
                    }
                }
            }
        }
        catch (Exception e)
        {
            throw (e);
        }
        return largest_value;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
