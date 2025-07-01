string filePath = @"C:/data/image.jpg";

FileInfo fileInfo = new(filePath);

if (!fileInfo.Exists)
{
    fileInfo.Create().Close();
}

var fileBytes = File.ReadAllBytes(fileInfo.FullName);

var fileBase64 = Convert.ToBase64String(fileBytes);

Console.WriteLine("Enter the path where you want to save the Base64 encoded file:");
string fileBase64Path = Console.ReadLine() ?? string.Empty;

using StreamWriter writer = new(fileBase64Path, false);
writer.WriteLine(fileBase64);

Console.WriteLine($"Base64 encoded file saved to {fileBase64Path}");