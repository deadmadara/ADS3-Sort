using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        int[] arr;
        public int find;
        public BinarySearch(int[] _arr)
        {
            find = 0;
            Left = 0;
            Right = _arr.Length - 1;
            arr = new int[_arr.Length];
            Array.Copy(_arr, arr, _arr.Length);
        }

         public void Step (int N)
        {
            if (find == 0)
            {

                int Center = (Left + Right) / 2;
                if (arr[Center] == N)
                {
                    find = 1;
                }
                else
                {
                        if (N < arr[Center])
                        {
                            Right = Center - 1;
                        }
                        else if (N > arr[Center])
                        {
                            Left = Center + 1;
                        }
                        Center = (Left + Right) / 2;
                        if (arr[Center] == N) find = 1;
                    if (Left == Right || Left < 0 || Right < 0 || Right > arr.Length)
                    {
                        find = -1;
                    }
                }
            }
        }

        public int GetResult()
        {
            return find;
        }
    }
}
