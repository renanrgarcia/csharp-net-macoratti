var directoryPath = @"D:\Data\MyDirectory";

Console.WriteLine("\n Creating a new directory:");

try
{
    if (!Directory.Exists(directoryPath))
    {
        Directory.CreateDirectory(directoryPath);
        Console.WriteLine($"Directory created at: {directoryPath}");
    }
    else
    {
        Console.WriteLine($"Directory already exists at: {directoryPath}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while creating the directory: {ex.Message}");
}

Console.WriteLine("\n Excluding a directory:");

try
{
    if (Directory.Exists(directoryPath))
    {
        Directory.Delete(directoryPath);
        Console.WriteLine($"Excluded directory at: {directoryPath}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while excluding the directory: {ex.Message}");
}

Console.WriteLine("\n Listing subdirectories of a directory:");
var baseDirectoryPath = @"D:/Data";

try
{
    if (Directory.Exists(baseDirectoryPath))
    {
        string[] subDirectories = Directory.GetDirectories(baseDirectoryPath, "*t");
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

Console.WriteLine("\n Getting the files of a directory:");

try
{
    if (Directory.Exists(baseDirectoryPath))
    {
        string[] files = Directory.GetFiles(baseDirectoryPath, "*.txt");
        foreach (var file in files)
        {
            Console.WriteLine($"File: {file}");
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

Console.WriteLine("Renaming (Moving) a directory:");

var sourceDirectoryPath = @"D:\Data\txt";

var destinationDirectoryPath = @"D:\Data\new_txt";

try
{
    if (Directory.Exists(sourceDirectoryPath))
    {
        Directory.Move(sourceDirectoryPath, destinationDirectoryPath);
        Console.WriteLine($"Directory moved from {sourceDirectoryPath} to {destinationDirectoryPath}");
    }
    else
    {
        Console.WriteLine("The source directory does not exist. Cannot move.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while moving the directory: {ex.Message}");
}