using System;
using System.Threading;
using System.Threading.Tasks;
using KafkaMessagingLib;

namespace Consumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var kafkaService = new KafkaService();

            kafkaService.SubscribeAsync<string>("testTopic", HandleEvent, HandleBy.OneInstance);
        }

        private static void HandleEvent(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Consumer receive message: {message}");
        }
    }
}
