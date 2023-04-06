using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SQS;
using Amazon.SQS.Model;


var snsArn = "arn:aws:sns:us-east-1:221307536465:teste";

IAmazonSQS client = new AmazonSQSClient(RegionEndpoint.USEast1);
var snsClient = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USEast1);


var request = new ReceiveMessageRequest
{
    QueueUrl = "https://sqs.us-east-1.amazonaws.com/221307536465/teste"
};

while (true)
{
    var response = await client.ReceiveMessageAsync(request);

    var x = 10;

    //foreach (var msg in response.Messages)
    //{

    //    await client.DeleteMessageAsync("https://sqs.us-east-1.amazonaws.com/221307536465/teste", msg.ReceiptHandle);
    //}
}
