using System.Diagnostics;

namespace AOC2022.Day9.Ropebridge;

public class RopePhysicsSimulator
{
    public PositionInRope HeadPosition { get; set; }
    public PositionInRope TailPosition { get; set; }

    public Dictionary<string, int> TailVisits { get; set; }

    public int TailUniqueLocationsVisited => CalculateTailUniqueLocationsVisited();


    public RopePhysicsSimulator(PositionInRope initialPosition, List<MotionInRope> motionInRopeList)
    {
        this.HeadPosition = new PositionInRope() {X = initialPosition.X, Y = initialPosition.Y};
        this.TailPosition = new PositionInRope() {X = initialPosition.X, Y = initialPosition.Y};
        this.TailVisits = new Dictionary<string, int>();
        
        this.UpdateTailVisits();
        this.SimulateMotionInRole(motionInRopeList);
    }

    private void SimulateMotionInRole(List<MotionInRope> motionInRopeList)
    {
        foreach (MotionInRope motionInRope in motionInRopeList)
        {
            for (int i = 0; i < motionInRope.Distance; i++)
            {
                MoveHead(motionInRope.Direction);
            }
        }
    }

    private void MoveHead(string motionDirection)
    {
        Debug.WriteLine($"Move the head {motionDirection}");
        
        switch (motionDirection)
        {
            case "U":
                this.HeadPosition.Y++;
                break;
            case "D":
                this.HeadPosition.Y--;
                break;
            case "L":
                this.HeadPosition.X--;
                break;
            case "R":
                this.HeadPosition.X++;
                break;
        }
        
        TailFollowsHead();
    }

    private void TailFollowsHead()
    {
        Debug.WriteLine($" - tail follows");
        
        if (!IsTailAdjacentToHead())
        {
            if (this.HeadPosition.X == this.TailPosition.X && this.HeadPosition.Y == this.TailPosition.Y)
            {
                // NOOP
            }
            else if (this.HeadPosition.X == this.TailPosition.X)
            {
                Debug.WriteLine($" - up / down");
                
                #region Same column, move up or down
                
                if (this.HeadPosition.Y > this.TailPosition.Y)
                {
                    this.TailPosition.Y++;      // We go up
                }
                else
                {
                    this.TailPosition.Y--;      // We go down
                }
                
                this.UpdateTailVisits();
                
                #endregion
            }
            else if (this.HeadPosition.Y == this.TailPosition.Y)
            {
                Debug.WriteLine($" - left / right");
                
                #region Same row, move left or right
                
                if (this.HeadPosition.X > this.TailPosition.X)
                {
                    this.TailPosition.X++;      // We go right
                }
                else
                {
                    this.TailPosition.X--;      // We go left
                }
                
                this.UpdateTailVisits();
                
                #endregion
            }
            else
            {
                Debug.WriteLine($" - diagonally");
                
                #region Move diagonally
                
                if (this.HeadPosition.Y > this.TailPosition.Y)
                {
                    this.TailPosition.Y++;      // We go up
                }
                else
                {
                    this.TailPosition.Y--;      // We go down
                }
                if (this.HeadPosition.X > this.TailPosition.X)
                {
                    this.TailPosition.X++;      // We go right
                }
                else
                {
                    this.TailPosition.X--;      // We go left
                }
                
                this.UpdateTailVisits();
                
                #endregion
            }
        }
    }

    private bool IsTailAdjacentToHead()
    {
        int xDistance = Math.Abs(this.HeadPosition.X - this.TailPosition.X);
        int yDistance = Math.Abs(this.HeadPosition.Y - this.TailPosition.Y);

        bool result = xDistance <= 1 && yDistance <= 1;
        
        return result;
    }

    private void UpdateTailVisits()
    {
        string tailLocation = this.TailPosition.ToString();
        
        Debug.WriteLine($" - update tail visits {tailLocation}");
        
        if (this.TailVisits.ContainsKey(tailLocation))
        {
            Debug.WriteLine($"   - update");
            this.TailVisits[tailLocation] += 1;
        }
        else
        {
            Debug.WriteLine($"   - new item");
            this.TailVisits.Add(this.TailPosition.ToString(), 1);
        }
    }

    private int CalculateTailUniqueLocationsVisited()
    {
        return this.TailVisits.Count;
    }
}