using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.

using var channel = GrpcChannel.ForAddress("https://localhost:7254");


var client = new Greeter.GreeterClient(channel);


var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Sarvesh" });
Console.WriteLine("Greeting: " + reply.Message);

var result = await client.DoAdditonAsync(
                  new AdditonRequest { First = 2, Second = 20 });
Console.WriteLine($"Sum of two number is {result.Sum}");





Console.WriteLine("Press any key to exit...");
Console.ReadKey();