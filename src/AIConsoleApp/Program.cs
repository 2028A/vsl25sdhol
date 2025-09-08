using System.ClientModel;
using OpenAI;
using OpenAI.Chat;

var endpoint = new Uri("https://models.github.ai/inference");
//var credential = System.Environment.GetEnvironmentVariable("GITHUB_TOKEN");
var credential = "xxxxx";
var model = "openai/gpt-4.1-mini";

var openAIOptions = new OpenAIClientOptions()
{
    Endpoint = endpoint
    
};

var client = new ChatClient(model, new ApiKeyCredential(credential), openAIOptions);

List<ChatMessage> messages = new List<ChatMessage>()
{
     new SystemChatMessage("You are a helpful C# programming assistant."),
       new UserChatMessage("Explain async/await in C# with a simple example."),
};

var requestOptions = new ChatCompletionOptions()
{
    Temperature = 1.0f,
    TopP = 1.0f,
};

var response = client.CompleteChat(messages, requestOptions);
System.Console.WriteLine(response.Value.Content[0].Text);

