using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaMessagingLib
{
    public enum HandleBy
    {
        OneInstance,
        AllInstances
    }

    public class KafkaService
    {
        private readonly TimeSpan _timeOut = TimeSpan.FromSeconds(30);

        private readonly ProducerConfig _producerConfig = new ProducerConfig
        {
            BootstrapServers = "localhost:9092",
            ClientId = "ProducerService",
            // Guarantees delivery of message to topic.
            EnableDeliveryReports = true
        };

        private readonly ConsumerConfig _consumerConfig = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "ConsumerService",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            AllowAutoCreateTopics = true,
            PartitionAssignmentStrategy = PartitionAssignmentStrategy.RoundRobin
        };

        public Task SendMessageAsync<T>(string topic, T message)
        {
            _producerConfig.Partitioner = Partitioner.ConsistentRandom;
            using var producer = new ProducerBuilder<Null, T>(_producerConfig).Build();

            producer.Produce(
                topic,
                new Message<Null, T> { Value = message },
                HandlerOnSend);

            producer.Flush();

            return Task.CompletedTask;
        }

        public async Task SendEventAsync<T>(string topic, T message)
        {
            _producerConfig.Partitioner = null;
            using var producer = new ProducerBuilder<Null, T>(_producerConfig).Build();

            var publishResult = await producer.ProduceAsync(
                 topic,
                 new Message<Null, T> { Value = message });

            if(publishResult.Status == PersistenceStatus.Persisted)
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Message published to {topic} topic");

            producer.Flush();
        }

        public Task SubscribeAsync<T>(string topic, Action<T> handlerAction, HandleBy handleBy)
        {
            if (handleBy == HandleBy.AllInstances)
                _consumerConfig.GroupId = $"{_consumerConfig.GroupId}-{Guid.NewGuid()}";

            using var consumer = new ConsumerBuilder<Ignore, T>(_consumerConfig).Build();

            consumer.Subscribe(topic);

            Console.WriteLine($"Consumer subscribed on {topic} topic and waiting for messages");

            while (true)
            {
                try
                {
                    var consumeResult = consumer.Consume();

                    if (consumeResult != null)
                        handlerAction(consumeResult.Message.Value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }

            consumer.Close();
            return Task.CompletedTask;
        }

        private void HandlerOnSend<T>(DeliveryReport<Null, T> deliveryReport)
        {
            if (deliveryReport.Error.IsLocalError)
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Local error while sending message: {deliveryReport.Error.Reason}, topic {deliveryReport.Topic}");
            else if (deliveryReport.Error.IsBrokerError)
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Broker error while sending message: {deliveryReport.Error.Reason}, topic {deliveryReport.Topic}");
            else if (deliveryReport.Error.IsFatal)
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Fatal error while sending message: {deliveryReport.Error.Reason}, topic {deliveryReport.Topic}");
            else if (deliveryReport.Error.IsError)
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Some error while sending message: {deliveryReport.Error.Reason}, topic {deliveryReport.Topic}");
            else
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Message delivered to {deliveryReport.Topic}");
        }
    }
}
