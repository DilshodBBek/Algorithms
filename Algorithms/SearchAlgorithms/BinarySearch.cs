namespace Algorithms.SearchAlgorithms
{
    public static class BinarySearch
    {
        public static int BinarySearching(this IList<int> collection, int number)
        {
            int count = 0;
            int L = 0, R = collection.Count() - 1;
            if (!(collection[R] < number && collection[0] > number))
            {
                return -1;
            }
            int M = 0;

            bool isFound = false;
            while (!isFound)
            {
                count++;
                M = (L + R) / 2;

                if (collection[M] == number)
                {
                    isFound = true;
                }
                else if (L==R)
                {
                    return -1;
                }
                else if (collection[M] > number)
                {
                    R = M - 1;
                }
                else
                {
                    L = M + 1;
                }
            }
            Console.WriteLine("Count:"+count);
            return M;
        }
      
    }
}
