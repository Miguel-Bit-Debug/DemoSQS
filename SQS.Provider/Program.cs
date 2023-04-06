using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Newtonsoft.Json;

var snsArn = "arn:aws:sns:us-east-1:221307536465:teste";

var message = new Product()
{
    Name = "aprovação",
    Event = "approved"
};

var messageRequest = new PublishRequest()
{
    Message = JsonConvert.SerializeObject(message),
    TopicArn = snsArn,
    MessageAttributes = new Dictionary<string, MessageAttributeValue>
    {
        { "name", new MessageAttributeValue()
            {
                StringValue = message.Event,
                DataType = "String"
            }
        }
    }
};

var snsClient = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USEast1);

await snsClient.PublishAsync(messageRequest);

public class Product
{
    public Product()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Event { get; set; }
}