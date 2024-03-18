using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitmqProductAPI.RabbitMQ
{
    public class RabbitMQProducer:IRabbitMQProducer
    {
        public void SendProductMessage<T>(T message)
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
            var connection = factory.CreateConnection();
          
            var channel = connection.CreateModel();
           
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish(exchange: "", routingKey: "Product", body: body);
        }
    }
}
