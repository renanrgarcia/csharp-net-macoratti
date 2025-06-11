try
{
    string path = @"D:\Data\file1.txt";

    // Create file
    if (!Directory.Exists(Path.GetDirectoryName(path)!))
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
    File.Create(path).Close();

    File.WriteAllText(path, "Hello World! \r\nThis is poem: \r\n");

    string newText = Environment.NewLine +
                     "The poet is a faker" +
                      Environment.NewLine +
                     "who always lies,\r\n" +
                     "who always tells the truth,\r\n" +
                     "who always lies,\r\n" +
                     "who always tells the truth,\r\n" +
                     "and never says goodbye.";

    File.AppendAllText(path, newText);

    // Read file
    Console.WriteLine("Reading file...");
    string content = File.ReadAllText(path);
    Console.WriteLine(content);
    Console.WriteLine();

    Console.WriteLine("Last file modification time: " +
                      File.GetLastWriteTime(path).ToString("dd/MM/yyyy HH:mm:ss") +
                      Environment.NewLine);

    Console.WriteLine("Last file access time: " +
                      File.GetLastAccessTime(path).ToString("dd/MM/yyyy HH:mm:ss") +
                      Environment.NewLine);

    string[] lines = File.ReadAllLines(path);

    foreach (var line in lines)
        Console.WriteLine(line);

    Console.WriteLine();

    // Copy file
    string copyPath = @"D:\Data\file1_copy.txt";
    if (!Directory.Exists(Path.GetDirectoryName(copyPath)!))
        Directory.CreateDirectory(Path.GetDirectoryName(copyPath)!);
    File.Copy(path, copyPath, overwrite: true);
    Console.WriteLine("File copied to: " + copyPath);
    Console.WriteLine();

    // Move file
    string movePath = @"D:\Data\txt\file1.txt";
    if (!Directory.Exists(Path.GetDirectoryName(movePath)!))
        Directory.CreateDirectory(Path.GetDirectoryName(movePath)!);
    File.Move(path, movePath, overwrite: true);
    Console.WriteLine("File moved to: " + movePath);

    // Delete files and directories
    Console.WriteLine("Deleting files and directories...");
    //if (File.Exists(copyPath))
    //{
    //    File.Delete(copyPath);
    //    Console.WriteLine("Deleted file: " + copyPath);
    //}

    //if (File.Exists(movePath))
    //{
    //    File.Delete(movePath);
    //    Console.WriteLine("Deleted file: " + movePath);
    //}

    if (Directory.Exists(@"D:\Data"))
    {
        Directory.Delete(@"D:\Data", recursive: true);
        Console.WriteLine("Deleted directory: D:\\Data");
    }

    Console.WriteLine("Press any key to exit.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
    Console.ReadKey();
}