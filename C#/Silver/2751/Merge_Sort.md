```ruby
using System;
using System.Collections.Generic;
using System.Reflection;

class solution_2751
{
    public static void MergeSort(int[] A, int start, int end)
    {
        if (start < end)
        {
            int middle = (start + end) / 2;
            MergeSort(A, start, middle);
            MergeSort(A, middle + 1, A.Length - 1);
            Merge(A, middle, A.Length - 1);
        }
    }

    public static void Merge(int[] A, int middle, int end)
    {
        int[] half_left = new int[middle + 1];
        int[] half_right = new int[end - middle];

        int k = 0;
        int i, j = 0;

        for (i = 0; k <= middle; i++, k++)
            half_left[i] = A[k];
        for (j = 0; k <= end; j++, k++)
            half_right[j] = A[k];

        k = i = j = 0;

        while (i < half_left.Length && j < half_right.Length)
        {
            if (half_left[i] < half_right[j])
                A[k++] = half_left[i++];
            else
                A[k++] = half_right[j++];
        }

        while (i < half_left.Length)
            A[k++] = half_left[i++];
        while (j < half_right.Length)
            A[k++] = half_right[j++];
    }

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        for (int n = 0; n < N; n++)
            A[n] = int.Parse(Console.ReadLine());

        MergeSort(A, 0, N-1);

        foreach (var i in A)
            Console.WriteLine(i);
    }
}
```
