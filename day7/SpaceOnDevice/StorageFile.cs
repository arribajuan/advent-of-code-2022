using System.Security.Cryptography.X509Certificates;

namespace AOC2022.Day7.SpaceOnDevice;

public class StorageFile
{
    public string Name { get; set; }
    public string Path { get; set; }
    public long Size { get; set; }

    public StorageFile()
    {
        this.Name = String.Empty;
        this.Path = String.Empty;
        this.Size = 0;
    }
}