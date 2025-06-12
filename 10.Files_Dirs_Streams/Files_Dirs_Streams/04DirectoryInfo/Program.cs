var directoryPath = @"D:\Data";

var originDirectory = new DirectoryInfo(directoryPath);

Console.WriteLine("Directory name: " + originDirectory.Name);
Console.WriteLine("Directory full path: " + originDirectory.FullName);
Console.WriteLine("Directory creation time: " + originDirectory.CreationTime);
Console.WriteLine("Directory last write time: " + originDirectory.LastWriteTime);
Console.WriteLine("Directory attributes: " + originDirectory.Attributes);

Console.WriteLine("Creating a new directory:");
var newDirectory = new DirectoryInfo(@"D:\Data\NewDir");
try
{
    if (!newDirectory.Exists)
    {
        newDirectory.Create();
        Console.WriteLine($"Directory created at: {newDirectory.FullName}");
    }
    else
    {
        Console.WriteLine($"Directory already exists at: {newDirectory.FullName}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while creating the directory: {ex.Message}");
}

Console.WriteLine("Deleting a directory:");
try
{
    if (newDirectory.Exists)
    {
        newDirectory.Delete();
        Console.WriteLine($"Directory deleted at: {newDirectory.FullName}");
    }
    else
    {
        Console.WriteLine($"Directory does not exist at: {newDirectory.FullName}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while deleting the directory: {ex.Message}");
}

Console.WriteLine("Exhibiting subdirectories:");

var direcoryBase = @"D:";

try
{
    if (Directory.Exists(direcoryBase))
    {
        var subDirectories = Directory.GetDirectories(direcoryBase, "*t");
        foreach (var subDir in subDirectories)
        {
            Console.WriteLine($"Subdirectory: {subDir}");
        }
    }
    else
    {
        Console.WriteLine("The specified directory does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while listing directories: {ex.Message}");
}

Console.WriteLine("Get files:");

try
{
    if (originDirectory.Exists)
    {
        var files = originDirectory.GetFiles();
        foreach (var file in files)
        {
            Console.WriteLine($"File: {file.Name}, Size: {file.Length} bytes, Last Modified: {file.LastWriteTime}");
        }
    }
    else
    {
        Console.WriteLine("The specified directory does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while getting files: {ex.Message}");
}