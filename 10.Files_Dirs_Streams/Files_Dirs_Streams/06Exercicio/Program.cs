string directoryPath = @"C:/data";

Console.WriteLine("Showing the files of the directory:");
if (Directory.Exists(directoryPath))
{
    var files = Directory.GetFiles(directoryPath);
    foreach (var file in files)
    {
        Console.WriteLine(file);
    }
}
else
{
    Console.WriteLine($"Directory {directoryPath} does not exist.");
}