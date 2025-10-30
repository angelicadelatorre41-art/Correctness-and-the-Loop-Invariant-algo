using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution { 
    public static void insertionSort (int[] A) { 
     for (int i = 1; i < A.Length; i++)
        {
            int value = A[i];
            int j = i - 1;

            while (j >= 0 && A[j] > value)
            {
                A[j + 1] = A[j];
                j--;
            }

            A[j + 1] = value;
        }

        Console.WriteLine(string.Join(" ", A));
    }

    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar);
    }
}


