// 1. Where
Console.WriteLine("1.Where - Words that contains 'a': ");
string[] words = ["apple", "banana", "cherry", "date", "elderberry"];

var containsA = words.Where(w => w.Contains('a'));

foreach (var word in containsA)
{
    Console.WriteLine(word);
}

Console.WriteLine();

// 2.OrderBy
Console.WriteLine("2.OrderBy - Ascending order values: ");
int[] unorderedNumbers = { 56, 23, 89, 12, 45, 78, 34, 91, 67, 11 };

var orderedNumbers = unorderedNumbers.OrderBy(n => n);

var orderedArray = orderedNumbers.ToArray();
for (int i = 0; i < orderedArray.Length; i++)
{
    if (i == orderedArray.Length - 1)
        Console.Write(orderedArray[i]);
    else
        Console.Write(orderedArray[i] + "->");
}

Console.WriteLine();
Console.WriteLine();

// 3.GroupBy
Console.WriteLine("3.GroupBy - Grouped by length of words: ");
var groupedWords = words.GroupBy(w => w.Length).OrderBy(g => g.Key);

foreach (var group in groupedWords)
{
    Console.WriteLine($"Length: {group.Key} - Words: {string.Join(", ", group)}");
}

Console.WriteLine();

//4.FirstOrDefault
Console.WriteLine("4.FirstOrDefault - First even number: ");
int[] ints = { 53, 12, 45, 78, 34, 91, 67, 11 };

var firstEven = ints.FirstOrDefault(i => i % 2 == 0);

Console.WriteLine(firstEven != 0 ? firstEven : "No even number found.");

Console.ReadKey();