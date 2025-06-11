
string originPath = @"D:\Data\poetry.txt";
string copyPath = @"D:\Data\poetry_copy.txt";
string destinationPath = @"D:\Data\txt\poetry.txt";

FileInfo originFile = new FileInfo(originPath);
Console.WriteLine("File name: " + originFile.Name);
Console.WriteLine("File full path: " + originFile.FullName);
Console.WriteLine("File is read-only: " + originFile.IsReadOnly);

var parentDirectory = originFile.Directory;
Console.WriteLine("Parent directory: " + parentDirectory!.FullName);

Console.WriteLine("File size: " + originFile.Length + " bytes");
Console.WriteLine("Last edited on: " + originFile.LastWriteTime);

if (originFile.Exists)
{
    Console.WriteLine($"The {originPath} file exists. Copying to {destinationPath}...");

    // Create a copy of the file
    originFile.CopyTo(copyPath, overwrite: true);
}
else
{
    Console.WriteLine("File does not exist at the specified path.");
}

if (originFile.Exists)
{
    Console.WriteLine($"Moving {originPath} to {destinationPath}...");
    originFile.MoveTo(destinationPath);
    Console.WriteLine("File moved successfully.");
}
else
{
    Console.WriteLine("The origin file does not exist. Cannot move.");
}

Console.WriteLine("Process completed successfully.");
Console.ReadKey();