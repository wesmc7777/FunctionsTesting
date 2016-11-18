using System;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Processing Queue trigger function processed: {myQueueItem}")
}