namespace AOC2022.Day9.Ropebridge;

public class RopeSimulator2
{
    public List<RopeKnot> Rope { get; set; }

    public RopeSimulator2(RopeKnot initialPosition, int ropeLength, List<MotionInRope> motionInRopeList)
    {
        this.InitializeRope(initialPosition, ropeLength);
        this.SimulateMotionInRope(motionInRopeList);
    }

    private void InitializeRope(RopeKnot initialPosition, int ropeLength)
    {
        this.Rope = new List<RopeKnot>();

        for (int i = 0; i < ropeLength; i++)
        {
            this.Rope.Add(new RopeKnot() { X = initialPosition.X, Y = initialPosition.Y });
        }
    }

    private void SimulateMotionInRope(List<MotionInRope> motionInRopeList)
    {
        
    }
}