using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.USEast1);
var request = new SendMessageRequest
{
    QueueUrl = "https://sqs.us-east-1.amazonaws.com/221307536465/teste",
    MessageBody = "teste 123"
};

await client.SendMessageAsync(request);
