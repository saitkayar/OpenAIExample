using AI.API.Example;
using AI.API.Example.Services;
using OpenAI.GPT3.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(set => set.ApiKey = "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");
     
        services.AddHostedService<OpenAICompletionService>();
    })
    .Build();

host.Run();
