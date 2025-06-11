MathOperation operation = Sum;

int result = operation.Invoke(2, 3);
Console.WriteLine(result); // Output: 5

static int Sum(int x, int y) => x + y;

delegate int MathOperation(int x, int y);
