using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        bool found;
        bool search;
        public BinarySearch(int[] arr)
        {
            Left = 0;
            Right = arr.Length - 1;
        }

        public void Step(int N)
        {
            found = false;
            search = true;
            if (Left == Right)
            {
                found = false;
                search = false;
            }
            int Center = (Left + Right) / 2;
                if (N == Center)
                {
                found = true;
                search = false;
                }
                else if (N < Center)
                {
                Right = Center - 1;
                }
                else if (N > Center)
                {
                Left = Center + 1;
                }
            }

        public int GetResult()
        {
            if (!found && !search) return -1;
            else if (!found && search) return 0;
            else return 1;
        }
    }
}
