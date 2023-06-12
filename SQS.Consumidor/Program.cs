using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using DotNetEnv;

internal class Program
{
    static async Task Main(string[] args)
    {
        DotNetEnv.Env.Load();

        var client = new AmazonSQSClient(RegionEndpoint.USWest2);

        var endpointAWSvariable = Environment.GetEnvironmentVariable("USER_ENDPOINT_AWS");

        var request = new ReceiveMessageRequest
        {
            QueueUrl = endpointAWSvariable
        };

        var response = await client.ReceiveMessageAsync(request);

        foreach (var message in response.Messages)
        {
            System.Console.WriteLine(message.Body);
            if(message.Body.Contains("fuck"))
            await client.DeleteMessageAsync(endpointAWSvariable, message.ReceiptHandle);
        }
    }

}