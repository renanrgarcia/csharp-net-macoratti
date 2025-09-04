string directoryPath = @"C:/data/08exercise";

Console.WriteLine("Create a new directory and a file on it:");

if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
    Console.WriteLine($"Directory {directoryPath} created.");
}
else
{
    Console.WriteLine($"Directory {directoryPath} already exists.");
}

if (!File.Exists(Path.Combine(directoryPath, "exercise08.txt")))
{
    File.WriteAllText(Path.Combine(directoryPath, "example.txt"), "This is an example file.");
    Console.WriteLine($"File {Path.Combine(directoryPath, "example.txt")} created with example content.");
}
else
{
    Console.WriteLine($"File {Path.Combine(directoryPath, "example.txt")} already exists.");
}