Console.WriteLine("Testing Task method...");
await DoSomethingAsync();
async Task DoSomethingAsync()
{
    // Simulate some asynchronous work
    await Task.Delay(1000);
    Console.WriteLine("Done!");
}

Console.WriteLine("Testing Task<T> method...");

var result = await GetNumberAsync();
Console.WriteLine($"The result is: {result}");

async Task<int> GetNumberAsync()
{
    // Simulate some asynchronous work
    await Task.Delay(1000);
    return 42; // Returning an integer value
}