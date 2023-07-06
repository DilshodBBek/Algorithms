using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public static class QuickSort
    {
        public static int[] QuickSorting(this int[] numbers)
        {
            if (!(numbers.Length > 1)) return numbers;
            List<int> left=new();
            List<int> right=new();
            int pivot = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (pivot < numbers[i])
                {
                    right.Add(numbers[i]);
                }
                else
                {
                    left.Add(numbers[i]);
                }
            }
            List<int> sorted = new();
            sorted.AddRange(QuickSorting(left.ToArray()));
            sorted.Add(pivot);
            sorted.AddRange(QuickSorting(right.ToArray()));
            return sorted.ToArray();
        }
    }
}
