using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace gRPCclient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press ENTER to continue!");
            Console.ReadLine();

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine($"Greetings: {reply.Message}");

            Console.WriteLine("Press any key to exit");
            Console.Read();


        }
    }
}
