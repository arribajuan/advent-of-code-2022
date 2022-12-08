namespace AOC2022.Day7.SpaceOnDevice;

public class Storage
{
    public StorageDirectory rootDirectory { get; private set; }

    public Storage(List<string> cliLog)
    {
        this.rootDirectory = new StorageDirectory();
        
        this.ParseCliLog(cliLog);
    }
    
    private StorageDirectory AddDirectory(StorageDirectory targetNode, string directoryName)
    {
        bool DoesDirectoryExist = false;
        foreach (StorageDirectory subDirectory in targetNode.SubDirectories)
        {
            if (subDirectory.Name == directoryName)
            {
                DoesDirectoryExist = true;
                return subDirectory;
            }
        }
        
        if (!DoesDirectoryExist)
        {
            StorageDirectory newNode = new StorageDirectory() { Name = directoryName, ParentDirectory = targetNode };
            targetNode.SubDirectories.Add(newNode);
            return newNode;
        }
        else
        {
            return null;
        }
    }
    
    private void ParseCliLog(List<string> cliLog)
    {
        this.rootDirectory = new StorageDirectory();
        StorageDirectory currentNode = this.rootDirectory;

        foreach (string cliEntry in cliLog)
        {
            if (cliEntry.Substring(0, 4).Equals(("$ cd")))
            {
                #region CD command
                
                string targetDirectory = cliEntry.Substring(5, cliEntry.Length - 5);
                
                if (targetDirectory == "/")
                {
                    currentNode = this.AddDirectory(currentNode, "");
                }
                else if (targetDirectory == "..")
                {
                    currentNode = currentNode.ParentDirectory;
                }
                else
                {
                    currentNode = this.AddDirectory(currentNode, targetDirectory);
                }
                
                #endregion
            }
            else if (cliEntry.Substring(0, 4).Equals(("$ ls")))
            {
                // NOOP
            }
            else if (cliEntry.Substring(0, 3).Equals("dir"))
            {
                // NOOP
            }
            else 
            {
                #region File
                
                string[] fileInfoArray = cliEntry.Split(' ');
                
                currentNode.Files.Add(
                new StorageFile()
                {
                    Path = currentNode.Path, 
                    Name = fileInfoArray[1],
                    Size = Convert.ToInt64(fileInfoArray[0])
                });

                #endregion
            }
        }
    }
    
    public long Star1Calculation(long directorySizeThreshold, StorageDirectory currentDirectory)
    {
        long result = 0;
        
        if (currentDirectory.TotalBranchSize <= directorySizeThreshold)
        {
            result += currentDirectory.TotalBranchSize;
        }
        
        foreach (StorageDirectory subDirectory in currentDirectory.SubDirectories)
        {
            result += this.Star1Calculation(directorySizeThreshold, subDirectory);
        }

        return result;
    }
    
    public void Star2Calculation(long directorySizeThreshold, StorageDirectory currentDirectory, ref long result)
    {
        System.Diagnostics.Debug.WriteLine($"{currentDirectory.TotalBranchSize} - {currentDirectory.Path}");

        if (currentDirectory.TotalBranchSize >= directorySizeThreshold)
        {
            System.Diagnostics.Debug.WriteLine(" - useful");
            if (result == 0 || result > currentDirectory.TotalBranchSize)
            {
                System.Diagnostics.Debug.WriteLine(" - we use it");
                result = currentDirectory.TotalBranchSize;
            }
        }
        
        foreach (StorageDirectory subDirectory in currentDirectory.SubDirectories)
        {
            this.Star2Calculation(directorySizeThreshold, subDirectory, ref result);
        }
    }
}
