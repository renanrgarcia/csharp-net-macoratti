string filePath = @"C:/data/Exercise.txt";

if (!File.Exists(filePath))
{
    Console.WriteLine($"File {filePath} does not exist. Please create it first.");
    return;
}

FileInfo fileInfo = new(filePath);

Console.WriteLine($"File creation date: {fileInfo.CreationTime}");