string directoryPath = @"C:/data";
DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

Console.WriteLine("Showing the subdirectories:");
if (Directory.Exists(directoryPath))
{
    var subdirectories = directoryInfo.GetDirectories();
    foreach (var subdirectory in subdirectories)
    {
        Console.WriteLine(subdirectory.Name);
    }
}
else
{
    Console.WriteLine($"Directory {directoryPath} does not exist.");
}