using Algorithms.RabbitMq;
using Algorithms.SearchAlgorithms;
using Algorithms.Sort;
using System.Diagnostics;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int[] numbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = random.Next(1, 99);
                //Console.Write(numbers[i]+" ");
            }
            Console.WriteLine("\n");

            //Stopwatch sw =new();
            //sw.Start();
            //foreach (int item in numbers.QuickSorting())
            //{
            //    Console.Write(item+" ");
            //} 
            //sw.Stop();
            //Console.WriteLine("\n"+sw.ElapsedMilliseconds);

            Stopwatch stopwatch = new();
            stopwatch.Start();
            foreach (int item in numbers.SelectionSorting())
            {
                Console.Write(item + " ");
            }
            stopwatch.Stop();
            Console.WriteLine("\n" + stopwatch.ElapsedMilliseconds);
            //  Subscriber.GetMessage();
            //List<int> numbers = new() { 3, 5, 12, 15, 17, 22, 46, 97, 125, 234, 456, 567, 789, 1234 };

            //Console.WriteLine("Index:" + numbers.BinarySearching(567));

        }
    }
}