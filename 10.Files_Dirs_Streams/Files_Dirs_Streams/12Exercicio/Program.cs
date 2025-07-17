Console.WriteLine("This program allows the user to delete a file or a directory from C:/data/");

Console.WriteLine("Please enter the path of the file or directory you want to delete:");
string? pathToDelete = Console.ReadLine();

if (pathToDelete != null)
{
    if (File.Exists(pathToDelete))
    {
        try
        {
            File.Delete(pathToDelete);
            Console.WriteLine($"File {pathToDelete} deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting file: {ex.Message}");
        }
    }
    else if (Directory.Exists(pathToDelete))
    {
        try
        {
            Directory.Delete(pathToDelete, true);
            Console.WriteLine($"Directory {pathToDelete} deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting directory: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine($"The specified path {pathToDelete} does not exist.");
    }
}
else
{
    Console.WriteLine("No path provided.");
}
