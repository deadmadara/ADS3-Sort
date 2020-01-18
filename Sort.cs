using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static int ArrayChunkPartition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }
        public static List<int> KthOrderStatisticsStep(int[] Array, int L, int R, int k)
        {
            List<int> pair = new List<int>();
            int N = ArrayChunkPartition(Array, L, R);

            if (N == k)
            {
                pair.Add(L);
                pair.Add(R);
            }
            else if (N < k)
            {
                pair.Add(N + 1);
                pair.Add(R);
            }
            else
            {
                pair.Add(L);
                pair.Add(N - 1);
            }
            return pair;
        }
    }
}