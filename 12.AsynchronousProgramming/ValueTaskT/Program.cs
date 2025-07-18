Console.WriteLine("Type the first number:");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Type the second number:");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

var sum = await AddNumbers(firstNumber, secondNumber); // Await the ValueTask directly

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");

Console.ReadKey();

static async ValueTask<int> AddNumbers(int a, int b)
{
    if (a == 0 && b == 0)
        return 0;

    return await Task.Run(() => a + b); // Task.Run is used to offload the computation to a thread pool thread  
}

//static async Task<int> AddNumbersTask(int a, int b)
//{
//    if (a == 0 && b == 0)
//        return 0;

//    return await Task.Run(() => a + b);
//}