using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        public bool found;
        public bool search;
        public BinarySearch(int[] arr)
        {
            Left = 0;
            Right = arr.Length - 1;
            found = false;
            search = true;
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
