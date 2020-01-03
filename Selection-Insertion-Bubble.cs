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

        public static bool BubbleSortStep(int[] array)
        {
            int count = 0;
            if (array != null)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[k] > array[k + 1])
                    {
                        int temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;
                        count++;
                    }
                }
                if (count == 0) return true;
            }
            return false;
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

                    while (!BubbleSortStep(temp));

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
