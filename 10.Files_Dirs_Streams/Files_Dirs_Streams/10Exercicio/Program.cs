string directoryPath = @"C:/data/09exercise/example.txt";
string targetDirectory = @"C:/data/10exercise";

Console.WriteLine("Move a file to a new directory:");

if (File.Exists(directoryPath))
{
    if (!Directory.Exists(targetDirectory))
    {
        Directory.CreateDirectory(targetDirectory);
        Console.WriteLine($"Directory {targetDirectory} created.");
    }
    string targetFilePath = Path.Combine(targetDirectory, "example.txt");
    if (!File.Exists(targetFilePath))
    {
        File.Move(directoryPath, targetFilePath);
        Console.WriteLine($"File moved to {targetFilePath}.");
    }
    else
    {
        Console.WriteLine($"File {targetFilePath} already exists.");
    }
}
else
{
    Console.WriteLine($"File {directoryPath} does not exist.");
}