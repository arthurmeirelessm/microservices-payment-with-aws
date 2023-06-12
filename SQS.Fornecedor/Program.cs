using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using SQS.Fornecedor.models;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Program
{
    static async Task Main(string[] args)
    {
        var msg = new MessageBodyJSON()
        {
            Body = "Msvgdgfgsggsdf",
            Status = 200
        };

        string Json = JsonSerializer.Serialize(msg);

        var client = new AmazonSQSClient(RegionEndpoint.USWest2);

        var request = new SendMessageRequest
        {
            QueueUrl = "https://sqs.us-west-2.amazonaws.com/517554276447/microservice-test",
            MessageBody = Json
        };

        await client.SendMessageAsync(request);
    }
}