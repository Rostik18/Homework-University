using System;
using System.Linq;
using System.Threading.Tasks;
using KafkaMessagingLib;

namespace Producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var kafkaService = new KafkaService();

            //Console.WriteLine("Using: start with '-E' for Event or '-M' for message");
            //Console.WriteLine("Using: add '-O' to send for One instance or '-A' to send for All available instances");
            //Console.WriteLine("Example: -M -A Hi all");
            //Console.WriteLine("By default chooses -M and -O");
            Console.WriteLine("Enter message");

            while (true)
            {
                var inputMessage = Console.ReadLine();

                if (inputMessage.StartsWith("-M -A"))
                    await kafkaService.SendMessageAsync("testTopic", inputMessage.Substring(6));
                if (inputMessage.StartsWith("-M -O"))
                    await kafkaService.SendMessageAsync("testTopic", inputMessage.Substring(6));
                if (inputMessage.StartsWith("-E -O"))
                    await kafkaService.SendEventAsync("testTopic", inputMessage.Substring(6));
                if (inputMessage.StartsWith("-E -A"))
                    await kafkaService.SendEventAsync("testTopic", inputMessage.Substring(6));
                else
                    await kafkaService.SendMessageAsync("testTopic", inputMessage);
            }

            Console.WriteLine("Producer stopped");
        }
    }
}