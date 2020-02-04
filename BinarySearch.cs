using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        int[] arr;
        public bool found;
        public bool search;
        public BinarySearch(int[] _arr)
        {
            Left = 0;
            Right = _arr.Length - 1;
            found = false;
            search = true;
            arr = new int[_arr.Length];
            Array.Copy(_arr, arr, _arr.Length);
        }

        public void Step(int N)
        {
            if (found == false || search == true)
            {
                if (Left == Right)
                {
                    found = false;
                    search = false;
                }
                else
                {
                    int Center = (Left + Right) / 2;
                    if (arr[Center] == N)
                    {
                        found = true;
                        search = false;
                    }
                    else if (N < arr[Center])
                    {
                        Right = Center - 1;
                    }
                    else if (N > arr[Center])
                    {
                        Left = Center + 1;
                    }
                }
            }
        }

        public int GetResult()
        {
            if (search == true)
            {
                return 0;
            }
            else 
            {
                if (found == true)
                    return 1;
                else return -1;
            }
        }
    }
}
