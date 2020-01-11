using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static int ArrayChunk(int[] M)
        {
            int pos = M.Length / 2;
            int N = M[pos];
            int i1 = 0;
            int i2 = M.Length - 1;

            while (i1 <= i2 )
            {
                while (M[i1] < N) i1++;
                while (M[i2] > N) i2--;
                if (i1 == i2 - 1 && M[i1] > M[i2])
                {
                    int temp = M[i1];
                    M[i1] = M[i2];
                    M[i2] = temp;
                    ArrayChunk(M);
                }
                else if (i1 == i2 || (i1 == i2 - 1 && M[i1] < M[i2])) return pos;
                else
                {
                    if (i1 == pos) pos++;
                    if (i2 == pos) pos--;
                    N = M[pos];
                    int temp1 = M[i1]; 
                    M[i1] = M[i2];
                    M[i2] = temp1;
                }
            }
            return pos;
        }
    }
}
