Console.WriteLine("This program returns the total size of a Directory:");

Console.WriteLine("Please enter the path of the directory you want to check:");
string? directoryPath = Console.ReadLine();
if (directoryPath == null)
{
    Console.WriteLine("No path provided.");
    return;
}

if (Directory.Exists(directoryPath))
{
    long totalSize = 0;
    var dirInfo = new DirectoryInfo(directoryPath);

    var files = dirInfo.GetFiles("*", SearchOption.AllDirectories);

    foreach (var file in files)
    {
        totalSize += file.Length;
    }

    Console.WriteLine($"Total size of directory '{directoryPath}' is {totalSize} bytes.");
}
else
{
    Console.WriteLine($"Directory {directoryPath} does not exist.");
}