namespace AOC2022.Day7.SpaceOnDevice;

public class StorageDirectory
{
    public StorageDirectory ParentDirectory { get; set; }
    public List<StorageDirectory> SubDirectories { get; set; }
    public List<StorageFile> Files { get; set; }
    public long TotalBranchSize { get; set; }

    public string Name { get; set; }
    public string Path { get; set; }

    public StorageDirectory()
    {
        this.SubDirectories = new List<StorageDirectory>();
        this.Files = new List<StorageFile>();
        this.TotalBranchSize = 0;
        this.Name = String.Empty;
        this.Path = String.Empty;
    }
        
    private void GeneratePath()
    {
        this.Path = "";

        StorageDirectory currentNode = this;
        this.Path = "/" + currentNode.Name + this.Path;
        
        while (currentNode.ParentDirectory != null)
        {
            currentNode = currentNode.ParentDirectory;
            if (currentNode.Name != String.Empty)
            {
                this.Path = "/" + currentNode.Name + this.Path;
            }
        }
    }
    

    public void AddDirectory(string path)
    {
        this.GeneratePath();
    }
    public void AddFile(string path, string fileName, long fileSize)
    {
        this.Files.Add(
            new StorageFile()
            {
                Path = path, 
                Name = fileName,
                Size = fileSize
            });
    }
    
}