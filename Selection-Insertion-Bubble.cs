using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void SelectionSortStep(int[] array, int i)
        {
            if (i >= 0 && i < array.Length && array != null)
            {
                int imin = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[imin])
                    {
                        imin = k;
                    }
                }
                int temp = array[i];
                array[i] = array[imin];
                array[imin] = temp;
            }
        }

        public static void InsertionSortStep(int[] array, int step, int i)
        {
            if (i >= 0 && i < array.Length && array != null)
            {
                    int iteration = i;
                    int k = 0;
                    int[] temp = new int[(array.Length - i - 1) / step + 1];
                    while (iteration < array.Length)
                    {
                        temp[k++] = (array[iteration]);
                    
                        iteration += step;
                    }
               
                for (int n = 1; n < temp.Length; n++)
                    {
                    int ins = n;
                    for (int m = n - 1; m >= 0; m--)
                    {
                        if (temp[n] < temp[m])
                        {
                            ins = m;
                        }
                    }
                    int tempvar = temp[n];
                    for (int m = n; m > ins; m--)
                    {
                        temp[m] = temp[m - 1];
                    }
                    temp[ins] = tempvar;
                    }

                iteration = i;
                    for (int n = 0; n < temp.Length; n++)
                    {
                        array[iteration] = temp[n];
                        iteration += step;
                    } 
            }
        }
   
    }
}
