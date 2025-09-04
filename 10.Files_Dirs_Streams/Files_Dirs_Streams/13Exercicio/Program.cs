Console.WriteLine("This program renames a file or a directory in C:/data/");

Console.WriteLine("Please enter the current path of the file or directory you want to rename:");

var path = @"C:/data/";
string? currentName = Console.ReadLine();
if (currentName == null)
{
    Console.WriteLine("No name provided.");
    return;
}

Console.WriteLine("Please enter the new name for the file or directory:");
string? newName = Console.ReadLine();
if (newName == null)
{
    Console.WriteLine("No new name provided.");
    return;
}

string currentPath = Path.Combine(path, currentName);
string newPath = Path.Combine(path, newName);

if (File.Exists(currentPath))
{
    try
    {
        File.Move(currentPath, newPath);
        Console.WriteLine($"File renamed from {currentName} to {newName} successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error renaming file: {ex.Message}");
    }
}
else if (Directory.Exists(currentPath))
{
    try
    {
        Directory.Move(currentPath, newPath);
        Console.WriteLine($"Directory renamed from {currentName} to {newName} successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error renaming directory: {ex.Message}");
    }
}
else
{
    Console.WriteLine($"The specified path {currentPath} does not exist.");
}