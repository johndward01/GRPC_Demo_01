// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcService;

var channel = GrpcChannel.ForAddress("http://localhost:5276");
var client = new Greeter.GreeterClient(channel);

var response = await client.GetFullNameAsync(new SampleRequest() { FirstName = "John", LastName = "Ward" });

Console.WriteLine(response);

Console.ReadLine();