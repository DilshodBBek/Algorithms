using RabbitMQ.Client;
using System.ComponentModel;
using System.Text;

namespace Algorithms.RabbitMq
{
    public class Publisher
    {
        public static void SendMessage()
        {
            var factory = new ConnectionFactory
            {
                HostName = "178.218.201.17",
                UserName = "jamshid",
                Password = "12345"
            };

            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            
            //var prop= channel.CreateBasicProperties();
            
            //Dictionary<string, object> properties = new();

            //properties.Add("Content-Type", "text");
            //properties.Add("Token", "123");
            //properties.Add("Username", "Jamshid");

         //   prop.Headers = properties;
            const string message = "Salom Hello World!";

            var body = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish(exchange: "InfoLog",
                                 routingKey: "InfoKey",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine($" [x] Sent {message}");

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
