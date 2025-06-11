Action<int> printNumber = x => Console.WriteLine(x);

for (var i = 1; i <= 20; i++)
{
    printNumber(i);
}
