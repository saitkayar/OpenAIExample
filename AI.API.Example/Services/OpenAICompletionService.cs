using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.API.Example.Services
{
    public class OpenAICompletionService : BackgroundService
    {
        private readonly IOpenAIService _openservice;

        public OpenAICompletionService(IOpenAIService openservice)
        {
            _openservice = openservice;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.WriteLine("::");
                var result = await _openservice.Completions.CreateCompletion(new CompletionCreateRequest()
                {
                    Prompt = "Once upon a time",
                    MaxTokens = 10 
                }, Models.TextDavinciV3);

                Console.WriteLine(result.Choices[0].Text);
            }
       
        }
    }
}
