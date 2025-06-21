// // Path Fields
// string path = @"C:\Users\16864107\Projects\Data\txt\poetry.txt";

// char dirSeparator = Path.DirectorySeparatorChar;
// Console.WriteLine($"Directory Separator: {dirSeparator}");

// string[] directories = path.Split(dirSeparator);

// Console.WriteLine("Directories in the path:");
// foreach (var directory in directories)
// {
//     Console.WriteLine(directory);
// }

// Path Methods
string path1 = @"C:\Users\16864107\Projects\Data";
string path2 = @"txt\poetry.txt";

string combinedPath = Path.Combine(path1, path2);
Console.WriteLine($"Combined Path: {combinedPath}");

Console.WriteLine($"File Name: {Path.GetFileName(combinedPath)}");
Console.WriteLine($"File Extension: {Path.GetExtension(combinedPath)}");
Console.WriteLine($"Directory Name: {Path.GetDirectoryName(combinedPath)}");
Console.WriteLine($"Full Path: {Path.GetFullPath(combinedPath)}");
Console.WriteLine($"Is Path Rooted: {Path.IsPathRooted(combinedPath)}");
Console.WriteLine($"Path Root: {Path.GetPathRoot(combinedPath)}");
Console.WriteLine($"Change Extension: {Path.ChangeExtension(combinedPath, ".md")}");

Console.WriteLine();

Console.WriteLine("Random file name: " + Path.GetRandomFileName());
Console.WriteLine("Temporary file name: " + Path.GetTempFileName());
Console.WriteLine("Temporary directory: " + Path.GetTempPath());
Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());

char[] invalidChars = Path.GetInvalidFileNameChars();
Console.WriteLine("Invalid characters for file names:" +
    new string(invalidChars));


Console.ReadKey();