namespace AOC2022.Day8.Treetop;

public class TreetopAnalyser
{
    public int[,] TreetopMatrix { get; private set; }
    public int[,] VisibilityMatrix { get; private set; }

    public int TotalVisibleTrees => this.CountVisibleTrees();

    public TreetopAnalyser(int[,] treetopMatrix)
    {
        this.TreetopMatrix = treetopMatrix;
        
        this.GenerateVisibilityMatrix();
    }

    private void GenerateVisibilityMatrix()
    {
        int totalRows = this.TreetopMatrix.GetLength(0);
        int totalColumns = this.TreetopMatrix.GetLength(1);

        #region Initialize visibility matrix

        this.VisibilityMatrix = new int[totalRows, totalColumns];

        for (int i = 0; i < totalRows; i++)
        {
            for (int j = 0; j < totalColumns; j++)
            {
                this.VisibilityMatrix[i, j] = 0;
            }
        }
        
        #endregion
        
        for (int i = 0; i < totalRows; i++)
        {
            for (int j = 0; j < totalColumns; j++)
            {
                this.ApplyTreeVisibility(i, j);
            }
        }
    }
    
    private void ApplyTreeVisibility(int treeRow, int treeColumn)
    {
        int totalRows = this.TreetopMatrix.GetLength(0);
        int totalColumns = this.TreetopMatrix.GetLength(1);
        
        int maximumHeight = -1;
        int treeHeight = this.TreetopMatrix[treeRow, treeColumn];

        # region Look from the left

        maximumHeight = -1;
        
        for (int j = 0; j < treeColumn; j++)
        {
            if (this.TreetopMatrix[treeRow, j] > maximumHeight)
            {
                maximumHeight = this.TreetopMatrix[treeRow, j];
            }
        }

        if (maximumHeight < treeHeight)
        {
            this.VisibilityMatrix[treeRow, treeColumn] = 1;
            //System.Diagnostics.Debug.WriteLine($"Tree of height {treeHeight} at ({treeRow}, {treeColumn}) is VISIBLE from the LEFT");
        }

        #endregion
        
        # region Look from the right
        
        maximumHeight = -1;
        
        for (int j = totalColumns - 1; j > treeColumn; j--)
        {
            if (this.TreetopMatrix[treeRow, j] > maximumHeight)
            {
                maximumHeight = this.TreetopMatrix[treeRow, j];
            }
        }

        if (maximumHeight < treeHeight)
        {
            this.VisibilityMatrix[treeRow, treeColumn] = 1;
            //System.Diagnostics.Debug.WriteLine($"Tree of height {treeHeight} at ({treeRow}, {treeColumn}) is VISIBLE from the RIGHT");
        }
        
        #endregion
        
        #region Look from the top
        
        maximumHeight = -1;

        for (int i = 0; i < treeRow; i++)
        {
            if (this.TreetopMatrix[i, treeColumn] > maximumHeight)
            {
                maximumHeight = this.TreetopMatrix[i, treeColumn];
            }
        }

        if (maximumHeight < treeHeight)
        {
            this.VisibilityMatrix[treeRow, treeColumn] = 1;
            //System.Diagnostics.Debug.WriteLine($"Tree of height {treeHeight} at ({treeRow}, {treeColumn}) is VISIBLE from the TOP");
        }
        
        #endregion
        
        #region Look from the bottom
        
        maximumHeight = -1;

        for (int i = totalRows - 1; i > treeRow; i--)
        {
            if (this.TreetopMatrix[i, treeColumn] > maximumHeight)
            {
                maximumHeight = this.TreetopMatrix[i, treeColumn];
            }
        }

        if (maximumHeight < treeHeight)
        {
            this.VisibilityMatrix[treeRow, treeColumn] = 1;
            //System.Diagnostics.Debug.WriteLine($"Tree of height {treeHeight} at ({treeRow}, {treeColumn}) is VISIBLE from the BOTTOM");
        }
        
        #endregion
    }

    private int CountVisibleTrees()
    {
        int result = 0;

        for (int i = 0; i < this.VisibilityMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < this.VisibilityMatrix.GetLength(1); j++)
            {
                result += this.VisibilityMatrix[i, j];
            }
        }
        
        return result;
    }
}