Func<int, int, int> sum = (x, y) => x + y;
Func<int, int, int> sub = (x, y) => x - y;

Console.WriteLine("Type one number:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Type another number:");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine("Type the operation you want to perform: sum or sub");
string operation = Console.ReadLine()!;

if (operation == "sum")
{
    Console.WriteLine($"The result is: {sum(x, y)}");
}
else if (operation == "sub")
{
    Console.WriteLine($"The result is: {sub(x, y)}");
}
else
{
    Console.WriteLine("Invalid operation. Please type 'sum' or 'sub'.");
}