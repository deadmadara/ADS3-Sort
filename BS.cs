using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        int flag;
        int[] array;

        public BinarySearch (int[] arr)
        {
            array = new int[arr.Length];
            Array.Copy(arr, array, arr.Length);
            Left = 0;
            Right = arr.Length - 1;
        }

        public void Step (int N)
        {
            if (flag == 0)
            {
                int Center = (Left + Right) / 2;
                if (array[Center] == N)
                {
                    flag = 1;
                }
                else
                {
                    if (Left == Right)
                    {
                        flag = -1;
                    }
                    else
                    {
                        if (N < array[Center])
                        {
                            Right = Center - 1;
                        }
                        if (N > array[Center])
                        {
                            Left = Center + 1;
                        }
                        if (Right < 0 || Left > array.Length - 1)
                        {
                            flag = -1;
                        }
                        Center = (Left + Right) / 2;
                        if (array[Center] == N)
                        {
                            flag = 1;
                        }
                        else if (Left == Right || Right - Left == 1)
                        {
                            flag = -1;
                        }
                    }
                }
            }
        }

        public int GetResult ()
        {
            return flag;
        }
    }
}
