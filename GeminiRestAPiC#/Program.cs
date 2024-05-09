using GeminiRestAPiC_.Services;
using Microsoft.Extensions.DependencyInjection;
class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddHttpClient<IGeminiService,GeminiService>();
        var serviceProvider = services.BuildServiceProvider();
        var geminiService = serviceProvider.GetRequiredService<IGeminiService>(); 
        var result = await geminiService.GenerateContentAsync("Who is Donald Trump?");
        Console.WriteLine(result);
    }

}
