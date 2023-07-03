using RabbitMQ.Client;
using System.Text;

namespace Algorithms.RabbitMq
{
    public class Publisher
    {
        public static void SendMessage()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            
            const string message = "Salom Hello World!";

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "Custom",
                                 routingKey: "RouteKey",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine($" [x] Sent {message}");

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
