namespace RabbitmqProductAPI.RabbitMQ
{
    public interface IRabbitMQProducer
    {
        public void SendProductMessage<T>(T message);

    }
}
