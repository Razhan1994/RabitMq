namespace RabitMqProducer.RabitMQ
{
    public interface IRabbitMqProducer
    {
        void SendProductMessage<T>(T message);
    }
}
