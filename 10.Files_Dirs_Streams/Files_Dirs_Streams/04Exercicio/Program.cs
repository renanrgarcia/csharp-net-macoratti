string filePath = @"C:/data/Exercise04.txt";

FileInfo fileInfo = new(filePath);

if (!fileInfo.Exists)
{
    fileInfo.Create().Close();
}

using StreamWriter writer = new(fileInfo.FullName, true);
writer.WriteLine("This is a cryptography exercise.");

if (OperatingSystem.IsWindows())
{
    fileInfo.Encrypt();
}
else
{
    Console.WriteLine("File encryption is only supported on Windows.");
}

Console.WriteLine($"Enter the name of the new file to copy the encrypted file to (without extension):");

string? newFileName = Console.ReadLine();
if (string.IsNullOrEmpty(newFileName))
{
    Console.WriteLine("Invalid file name. Please try again.");
    return;
}

string newFilePath = Path.Combine(fileInfo.DirectoryName ?? string.Empty, $"{newFileName}.txt");

if (!Directory.Exists(fileInfo.DirectoryName))
{
    Directory.CreateDirectory(fileInfo.DirectoryName!);
}

fileInfo.CopyTo(newFilePath, true);