using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

public class Program
{
    private static async Task Main(string[] args)
    {
        var client = new AmazonSQSClient(RegionEndpoint.USWest2);

        var request = new SendMessageRequest
        {
            QueueUrl = "https://sqs.us-west-2.amazonaws.com/517554276447/microservice-test",
            MessageBody = "Teste 123"
        };

        await client.SendMessageAsync(request);
    }
}