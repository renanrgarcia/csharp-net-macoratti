Console.WriteLine("Testing ValueTask and ValueTask<T>");

Console.ReadKey();

await DoSomethingAsync();

var result = await GetNumberAsync(21);

Console.WriteLine("The result is: {0}", result);

static async ValueTask DoSomethingAsync()
{
    // Simulate some asynchronous work
    await Task.Delay(2000);
    Console.WriteLine("Done with ValueTask!");
}

static async ValueTask<int> GetNumberAsync(int value)
{
    // Simulate some asynchronous work
    await Task.Delay(2000);
    Console.WriteLine("Returning a number with ValueTask<T>!");
    return value * 2; // Returning an integer value times two
}
