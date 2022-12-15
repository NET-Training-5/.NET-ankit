class FIleIO
{
    public void CreateFile()
    {
        string folderPath = @"I:\New folder\.NET-ankit";
        string fileName = "abc.txt";
        string fullPath = @$"{folderPath}\{fileName}";
        File.Create(fullPath);
        File.WriteAllText(fullPath, "Hello Ankit how are you");
    }
    // public void CreateAnother()
    // {
    //     string folderPath = @"I:\New folder\.NET-ankit";
    //     string fileName = "ankit.txt";
    //     string fullPath = @$"{folderPath}\{fileName}";
    //     // File.Create(fullPath);
    //     // File.WriteAllText(fullPath,"Hello how are you");
    // }
    public void CreateDirectory()
    {
        string folderPath = @"I:\New folder\.NET-ankit";
        string newFolderPath = folderPath + "\\ybc";
        Directory.CreateDirectory(newFolderPath);

    }
    


}