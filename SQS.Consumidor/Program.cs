using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

public class Program
{
    private static void Main(string[] args)
    {
        var client = new Amazon.SQS.Client(RegionEndpoint.USEast1);

        var request = new ReceiveMessageRequest
        {
            QueueUrl = "https://sqs.us-west-2.amazonaws.com/517554276447/microservice-test"
        };

        await client.ReceiveMessageRequest(request);  



    }
}