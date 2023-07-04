using Algorithms.RabbitMq;
using Algorithms.SearchAlgorithms;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Publisher.SendMessage();
                Console.WriteLine();

            }
          //  Subscriber.GetMessage();
            //List<int> numbers = new() { 3, 5, 12, 15, 17, 22, 46, 97, 125, 234, 456, 567, 789, 1234 };

            //Console.WriteLine("Index:" + numbers.BinarySearching(567));

        }
    }
}