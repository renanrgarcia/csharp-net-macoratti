string directoryPath = @"C:/data/";

Console.WriteLine("List all files and directories in the specified path:");

if (Directory.Exists(directoryPath))
{
    var dirInfo = new DirectoryInfo(directoryPath);
    var entries = dirInfo.GetFileSystemInfos();
    foreach (var entry in entries)
    {
        Console.WriteLine(Path.Combine(directoryPath, entry.Name));
    }
}
else
{
    Console.WriteLine($"Directory {directoryPath} does not exist.");
}