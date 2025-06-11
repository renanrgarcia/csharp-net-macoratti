Action<int> printEven = x =>
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
};

for (var i = 1; i <= 20; i++)
{
    printEven(i);
}
