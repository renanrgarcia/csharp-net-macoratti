Console.WriteLine("This program returns the most recent file in a directory:");

Console.WriteLine("Please enter the path of the directory you want to check:");
string? directoryPath = Console.ReadLine();
if (directoryPath == null)
{
    Console.WriteLine("No path provided.");
    return;
}

if (Directory.Exists(directoryPath))
{
    var dirInfo = new DirectoryInfo(directoryPath);
    var files = dirInfo.GetFiles("*", SearchOption.TopDirectoryOnly);
    if (files.Length == 0)
    {
        Console.WriteLine($"No files found in directory '{directoryPath}'.");
        return;
    }
    FileInfo? mostRecentFile = null;
    foreach (var file in files)
    {
        if (mostRecentFile == null || file.LastWriteTime > mostRecentFile.LastWriteTime)
        {
            mostRecentFile = file;
        }
    }
    if (mostRecentFile != null)
    {
        Console.WriteLine($"The most recent file in directory '{directoryPath}' is '{mostRecentFile.Name}' with last write time {mostRecentFile.LastWriteTime}.");
    }
}
else
{
    Console.WriteLine($"Directory {directoryPath} does not exist.");
}