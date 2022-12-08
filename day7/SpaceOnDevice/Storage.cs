using System;
using System.Text;

namespace AOC2022.Day7.SpaceOnDevice;

public class Storage
{
    public List<StorageFile> fileList { get; private set; }
    public List<StorageDirectory> directoryList { get; private set; }

    public Storage(List<string> cliLog)
    {
        this.fileList = new();
        this.directoryList = new List<StorageDirectory>();
        
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
        StorageDirectory nodes = new StorageDirectory();
        StorageDirectory currentNode = nodes;

        foreach (string cliEntry in cliLog)
        {
            System.Diagnostics.Debug.WriteLine($"{cliEntry}");

            if (cliEntry.Substring(0, 4).Equals(("$ cd")))
            {
                #region CD command
                
                string targetDirectory = cliEntry.Substring(5, cliEntry.Length - 5);
                
                if (targetDirectory == "/")
                {
                    currentNode = this.AddDirectory(currentNode, "");
                    currentNode.AddDirectory("");
                }
                else if (targetDirectory == "..")
                {
                    currentNode = currentNode.ParentDirectory;
                }
                else
                {
                    currentNode = this.AddDirectory(currentNode, targetDirectory);
                    currentNode.AddDirectory("");
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
                currentNode.AddFile(currentNode.Path, fileInfoArray[1], Convert.ToInt64(fileInfoArray[0]));

                #endregion
            }
        }

        int a = 0;
    }
    
    
    /*
    
    private void CalculateFolderSizes()
    {
        var folderTotals =
            from file in this.fileList
            group file by file.Path
            into fileGroup
            select new
            {
                Path = fileGroup.Key,
                Size = fileGroup.Sum(x => x.Size)
            };

        this.folderList = new List<StorageFolder>();
        
        var distinctFolders = ( from file in this.fileList select file.Path).Distinct().ToList();

        foreach (string path in distinctFolders)
        {
            var folderTotal =
                (from file in this.fileList
                    where file.Path.Contains(path)
                    select file.Size).Sum();

            StorageFolder sf = new StorageFolder
            {
                Path = path,
                Size = folderTotal
            };
            this.folderList.Add(sf);
        }
        
        var result = folderTotals.ToList();
        var a = 0;
    }

    
    
    
    private string GeneratePathStringFromStack(Stack<string> pathStack)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (string s in pathStack.Reverse())
        {
            sb.Append(s);
        }

        return sb.ToString();
    }

    

private void ParseCliLog(List<string> cliLog)
{
    
    Stack<string> pathStack = new Stack<string>();
    
    foreach (string cliEntry in cliLog)
    {
        System.Diagnostics.Debug.WriteLine($"{cliEntry}");

        if (cliEntry.Substring(0, 4).Equals(("$ cd")))
        {
            #region CD command
            
            string targetDirectory = cliEntry.Substring(5, cliEntry.Length - 5);
            
            if (targetDirectory == "/")
            {
                pathStack.Clear();
                pathStack.Push("/");
            }
            else if (targetDirectory == "..")
            {
                pathStack.Pop();
            }
            else
            {
                pathStack.Push(targetDirectory + "/");
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
            StorageFile sf = new StorageFile
            {
                Path = this.GeneratePathStringFromStack(pathStack),
                Name = fileInfoArray[1],
                Size = Convert.ToInt32(fileInfoArray[0])
            };
            this.fileList.Add(sf);
            
            #endregion
        }
    }
    
}

*/
    
    /*
directory e is 584 because it contains a single file i of size 584 and no other directories.
directory a has total size 94853 because it contains files f (size 29116), g (size 2557), and h.lst (size 62596), plus file i indirectly (a contains e which contains i).
Directory d has total size 24933642.
/ contains every file. Its total size is 48381165, the sum of the size of every file.
    */
}
