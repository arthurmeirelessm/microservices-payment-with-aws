using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using SQS.Fornecedor.models;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetEnv;

public class Program
{
    static async Task Main(string[] args)
    {
        var msgRequest = new MessageBodyJSON()
        {
            Body = "ALA EU DE PO fuck",
            Status = 200
        };

        string Json = JsonSerializer.Serialize(msgRequest);
         
        DotNetEnv.Env.Load();

        var client = new AmazonSQSClient(RegionEndpoint.USWest2);

        var request = new SendMessageRequest
        {
            QueueUrl = Environment.GetEnvironmentVariable("USER_ENDPOINT_AWS"),
            MessageBody = Json
        };

        await client.SendMessageAsync(request);
    }
}