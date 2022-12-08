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
    
    
    
    
    
    /*
     
To begin, find all of the directories with a total size of at most 100000, 
then calculate the sum of their total sizes. 

In the example above, these directories are a and e; the sum of their total sizes is 95437 (94853 + 584). (As in this example, this process can count files more than once!)

Find all of the directories with a total size of at most 100000. What is the sum of the total sizes of those directories?
     
     
directory e is 584 because it contains a single file i of size 584 and no other directories.
directory a has total size 94853 because it contains files f (size 29116), g (size 2557), and h.lst (size 62596), plus file i indirectly (a contains e which contains i).
Directory d has total size 24933642.
/ contains every file. Its total size is 48381165, the sum of the size of every file.
    */
}
