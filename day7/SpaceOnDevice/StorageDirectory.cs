namespace AOC2022.Day7.SpaceOnDevice;

public class StorageDirectory
{
    public StorageDirectory ParentDirectory { get; set; }
    public List<StorageDirectory> SubDirectories { get; set; }
    public List<StorageFile> Files { get; set; }
    public long TotalBranchSize
    {
        get { return this.GetTotalBranchSize(); }
    }
    public string Path
    {
        get { return this.GetPath(); }
    }
    public string Name { get; set; }
    
    public StorageDirectory()
    {
        this.SubDirectories = new List<StorageDirectory>();
        this.Files = new List<StorageFile>();
        this.Name = String.Empty;
    }

    private long GetTotalBranchSize()
    {
        long result = 0;
        
        foreach (StorageFile sf in this.Files)
        {
            result += sf.Size;
        }

        foreach (StorageDirectory sd in this.SubDirectories)
        {
            result += sd.TotalBranchSize;
        }
        
        return result;
    }

    private string GetPath()
    {
        string result = "";

        StorageDirectory currentNode = this;
        result = "/" + currentNode.Name + result;
        
        while (currentNode.ParentDirectory != null)
        {
            currentNode = currentNode.ParentDirectory;
            if (currentNode.Name != String.Empty)
            {
                result = "/" + currentNode.Name + result;
            }
        }
        
        return result;
    }
}