using System.Diagnostics;

namespace AOC2022.Day9.Ropebridge;

public class RopePhysicsSimulator
{
    public RopePhysicsSimulator(PositionInRope initialPosition, List<MotionInRope> motionInRopeList)
    {
        HeadPosition = new PositionInRope { X = initialPosition.X, Y = initialPosition.Y };
        TailPosition = new PositionInRope { X = initialPosition.X, Y = initialPosition.Y };
        TailVisits = new Dictionary<string, int>();

        UpdateTailVisits();
        SimulateMotionInRole(motionInRopeList);
    }

    public PositionInRope HeadPosition { get; set; }
    public PositionInRope TailPosition { get; set; }

    public Dictionary<string, int> TailVisits { get; set; }

    public int TailUniqueLocationsVisited => CalculateTailUniqueLocationsVisited();

    private void SimulateMotionInRole(List<MotionInRope> motionInRopeList)
    {
        foreach (var motionInRope in motionInRopeList)
            for (var i = 0; i < motionInRope.Distance; i++)
                MoveHead(motionInRope.Direction);
    }

    private void MoveHead(string motionDirection)
    {
        Debug.WriteLine($"Move the head {motionDirection}");

        switch (motionDirection)
        {
            case "U":
                HeadPosition.Y++;
                break;
            case "D":
                HeadPosition.Y--;
                break;
            case "L":
                HeadPosition.X--;
                break;
            case "R":
                HeadPosition.X++;
                break;
        }

        TailFollowsHead();
    }

    private void TailFollowsHead()
    {
        Debug.WriteLine(" - tail follows");

        if (!IsTailAdjacentToHead())
        {
            if (HeadPosition.X == TailPosition.X && HeadPosition.Y == TailPosition.Y)
            {
                // NOOP
            }
            else if (HeadPosition.X == TailPosition.X)
            {
                Debug.WriteLine(" - up / down");

                #region Same column, move up or down

                if (HeadPosition.Y > TailPosition.Y)
                    TailPosition.Y++; // We go up
                else
                    TailPosition.Y--; // We go down

                UpdateTailVisits();

                #endregion
            }
            else if (HeadPosition.Y == TailPosition.Y)
            {
                Debug.WriteLine(" - left / right");

                #region Same row, move left or right

                if (HeadPosition.X > TailPosition.X)
                    TailPosition.X++; // We go right
                else
                    TailPosition.X--; // We go left

                UpdateTailVisits();

                #endregion
            }
            else
            {
                Debug.WriteLine(" - diagonally");

                #region Move diagonally

                if (HeadPosition.Y > TailPosition.Y)
                    TailPosition.Y++; // We go up
                else
                    TailPosition.Y--; // We go down
                if (HeadPosition.X > TailPosition.X)
                    TailPosition.X++; // We go right
                else
                    TailPosition.X--; // We go left

                UpdateTailVisits();

                #endregion
            }
        }
    }

    private bool IsTailAdjacentToHead()
    {
        var xDistance = Math.Abs(HeadPosition.X - TailPosition.X);
        var yDistance = Math.Abs(HeadPosition.Y - TailPosition.Y);

        var result = xDistance <= 1 && yDistance <= 1;

        return result;
    }

    private void UpdateTailVisits()
    {
        var tailLocation = TailPosition.ToString();

        Debug.WriteLine($" - update tail visits {tailLocation}");

        if (TailVisits.ContainsKey(tailLocation))
        {
            Debug.WriteLine("   - update");
            TailVisits[tailLocation] += 1;
        }
        else
        {
            Debug.WriteLine("   - new item");
            TailVisits.Add(TailPosition.ToString(), 1);
        }
    }

    private int CalculateTailUniqueLocationsVisited()
    {
        return TailVisits.Count;
    }
}