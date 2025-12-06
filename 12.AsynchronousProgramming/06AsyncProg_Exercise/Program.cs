await OperationExecutionAsync();

Console.ReadKey();

static async Task OperationExecutionAsync()
{
    var time = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(time));

    Console.WriteLine("\nOperation started...");
    Console.WriteLine($"Cancellation will occur after {time} seconds.");

    try
    {
        using var httpClient = new HttpClient();
        var destination = "c:\\data\\file.txt";

        var response = await httpClient.GetAsync("https://macoratti.net/dados/Poesia.txt",
                            HttpCompletionOption.ResponseHeadersRead,
                            cancellationTokenSource.Token);

        var totalBytes = response.Content.Headers.ContentLength;
        var readBytes = 0L;

        await using var fileStream = new FileStream(destination, FileMode.Create, FileAccess.Write);

        await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);

        var buffer = new byte[81920]; // 80 KB buffer
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer.AsMemory(0, buffer.Length), cancellationTokenSource.Token)) > 0)
        {
            await fileStream.WriteAsync(buffer.AsMemory(0, bytesRead), cancellationTokenSource.Token);
            readBytes += bytesRead;
            if (totalBytes.HasValue)
            {
                var progress = (double)readBytes / totalBytes.Value * 100;
                Console.WriteLine($"Downloaded {readBytes} of {totalBytes} bytes. ({progress:F2}%)");
            }
            else
            {
                Console.WriteLine($"Downloaded {readBytes} bytes.");
            }
        }
    }
    catch (OperationCanceledException ex)
    {
        if (cancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload canceled by timeout limit: " + ex.Message);
        }
        else
        {
            Console.WriteLine($"The operation timed out: {ex.Message}");
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine("There was a network error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An unexpected error occurred: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Download completed.");
    }
}
