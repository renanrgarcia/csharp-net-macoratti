int[] numbers = { 1, 2, 3, 4, 5 };

// Delegate Action
Action<int> exhibitNumber = num => Console.WriteLine(num);
Array.ForEach(numbers, exhibitNumber);
// Output: 1, 2, 3, 4, 5

// Delegate Predicate
Predicate<int> isEven = num => num % 2 == 0;
bool allEven = Array.TrueForAll(numbers, isEven);
Console.WriteLine(allEven);
// Output: false

// Delegate Func
Func<int, int, int> sum = (a, b) => a + b;
int result = sum(10, 20);
Console.WriteLine(result);
// Output: 30

Console.ReadKey();