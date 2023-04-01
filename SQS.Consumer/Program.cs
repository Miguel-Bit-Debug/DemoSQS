using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.USEast1);
var request = new ReceiveMessageRequest
{
    QueueUrl = "https://sqs.us-east-1.amazonaws.com/221307536465/teste"
};

while (true)
{
    var response = await client.ReceiveMessageAsync(request);

    foreach (var msg in response.Messages)
    {

        await client.DeleteMessageAsync("https://sqs.us-east-1.amazonaws.com/221307536465/teste", msg.ReceiptHandle);
    }
}
