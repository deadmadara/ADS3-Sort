using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        //сортировка слиянием
                static int[] MergeSortLH(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSortLH(array, lowIndex, middleIndex);
                MergeSortLH(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

 public static List<int> MergeSort(List<int> array)
        {
            int[] arr = new int[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                arr[i] = array[i];
            }
            int[] buff = MergeSortLH(arr, 0, array.Count);
            List<int> res = new List<int>();
            for (int i = 0; i < buff.Length; i++) res.Add(buff[i]);
            return res;
        }
    }
    }
}
