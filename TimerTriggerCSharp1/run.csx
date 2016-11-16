using System;

public static async Task Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");    

    string url = "https://wesmcfunctiontesting.azurewebsites.net/HttpTriggerNodeJS1?code=xz0qzu7rrne83iwo1y9sbgldimo2o1pca7oxm8eu7kgxh6w29g6zz9bwvvhhtk23v4hrggb9&name=WesleyMcSwain%20Test%20Timer&number=+19802413993";

    using (HttpClient httpClient = new HttpClient())
    {
        var response = await httpClient.GetAsync(new Uri(url));
    }
}