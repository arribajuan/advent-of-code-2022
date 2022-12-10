using System.Diagnostics;

namespace AOC2022.Day9.Ropebridge;

public class RopeSimulator2
{
    public List<RopeKnot> Rope { get; set; }
    
    public Dictionary<string, int> TailVisits { get; set; }
    
    public int TailUniqueLocationsVisited => CalculateTailUniqueLocationsVisited();
    
    public RopeSimulator2(RopeKnot initialPosition, List<MotionInRope> motionInRopeList, int ropeLength)
    {
        TailVisits = new Dictionary<string, int>();
        
        InitializeRope(initialPosition, ropeLength);
        UpdateTailVisits(Rope[ropeLength - 1]);
        SimulateMotionInRope(motionInRopeList);
    }

    private void InitializeRope(RopeKnot initialPosition, int ropeLength)
    {
        Rope = new List<RopeKnot>();

        for (var i = 0; i < ropeLength; i++)
        {
            Rope.Add(new RopeKnot
            {
                KnotNumber = i + 1,
                X = initialPosition.X,
                Y = initialPosition.Y,
                IsHead = (i == 0),
                IsTail = (i == ropeLength - 1)
            });
        }
    }

    private void SimulateMotionInRope(List<MotionInRope> motionInRopeList)
    {
        foreach (var motionInRope in motionInRopeList)
        {
            for (var i = 0; i < motionInRope.Distance; i++)
            {
                MoveRope(motionInRope.Direction);
            }
        }
    }

    private void MoveRope(string motionDirection)
    {
        // Move the head
        MoveRopeHead(motionDirection, this.Rope[0]);

        // Iterate the rest of the rope to follow
        for (var i = 1; i < Rope.Count; i++)
        {
            // Knot follows previous knot
            MoveFollowingKnot(Rope[i - 1], Rope[i]);
        }
        
        Debug.WriteLine("");
    }

    private void MoveRopeHead(string motionDirection, RopeKnot knot)
    {
        Debug.WriteLine($"Move: {knot.ToString()} to the {motionDirection}");

        switch (motionDirection)
        {
            case "U":
                knot.Y++;
                break;
            case "D":
                knot.Y--;
                break;
            case "L":
                knot.X--;
                break;
            case "R":
                knot.X++;
                break;
        }

        Debug.WriteLine($" - result: {knot.ToString()}");
    }

    private void MoveFollowingKnot(RopeKnot leadKnot, RopeKnot followingKnot)
    {
        Debug.WriteLine($"{followingKnot.ToString()} follows {leadKnot.ToString()}");

        if (!AreNodesAdjacent(leadKnot, followingKnot))
        {
            #region Move following node 

            Debug.WriteLine(" - need to follow");
            
            if (leadKnot.X == followingKnot.X && leadKnot.Y == followingKnot.Y)
            {
                // NOOP
            }
            else if (leadKnot.X == followingKnot.X)
            {
                #region Same column, move up or down
                
                Debug.WriteLine("   - up / down");

                if (leadKnot.Y > followingKnot.Y)
                    followingKnot.Y++; // We go up
                else
                    followingKnot.Y--; // We go down

                UpdateTailVisits(followingKnot);
                
                #endregion
            }
            else if (leadKnot.Y == followingKnot.Y)
            {
                #region Same row, move left or right

                Debug.WriteLine("   - left / right");
                
                if (leadKnot.X > followingKnot.X)
                    followingKnot.X++; // We go right
                else
                    followingKnot.X--; // We go left

                UpdateTailVisits(followingKnot);
                
                #endregion
            }
            else
            {
                #region Move diagonally

                Debug.WriteLine("   - diagonally");
                
                if (leadKnot.Y > followingKnot.Y)
                    followingKnot.Y++; // We go up
                else
                    followingKnot.Y--; // We go down
                if (leadKnot.X > followingKnot.X)
                    followingKnot.X++; // We go right
                else
                    followingKnot.X--; // We go left
                
                UpdateTailVisits(followingKnot);
                
                #endregion
            }
            
            Debug.WriteLine($"   - result: {followingKnot.ToString()}");

            #endregion
        }
    }
    
    private bool AreNodesAdjacent(RopeKnot leadKnot, RopeKnot followingKnot)
    {
        var xDistance = Math.Abs(leadKnot.X - followingKnot.X);
        var yDistance = Math.Abs(leadKnot.Y - followingKnot.Y);

        var result = xDistance <= 1 && yDistance <= 1;

        return result;
    }
    
    private void UpdateTailVisits(RopeKnot nodeMoved)
    {
        if (nodeMoved.IsTail)
        {
            string tailLocation = $"({nodeMoved.X}, {nodeMoved.Y})";

            Debug.WriteLine($"   - update tail visits {tailLocation}");

            if (TailVisits.ContainsKey(tailLocation))
            {
                Debug.WriteLine("     - update");
                TailVisits[tailLocation] += 1;
            }
            else
            {
                Debug.WriteLine("     - new item");
                TailVisits.Add(tailLocation, 1);
            }
        }
    }
    
    private int CalculateTailUniqueLocationsVisited()
    {
        return TailVisits.Count;
    }
}