string filePath = @"C:/data/Exercise.txt";

Console.Write("\nWhich is the path for the copy of the file: ");
var copyPath = Console.ReadLine();

if (string.IsNullOrEmpty(copyPath))
{
    Console.WriteLine("Invalid path. Please try again.");
    return;
}

if (!File.Exists(filePath))
{
    Console.WriteLine($"File {filePath} does not exist. Please create it first.");
    return;
}

FileInfo fileInfo = new(filePath);

if (!Directory.Exists(Path.GetDirectoryName(copyPath)!))
{
    Directory.CreateDirectory(Path.GetDirectoryName(copyPath)!);
}

fileInfo.CopyTo(copyPath, true);

