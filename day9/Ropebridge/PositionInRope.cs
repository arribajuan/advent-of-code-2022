namespace AOC2022.Day9.Ropebridge;

public class PositionInRope
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"({this.X},{this.Y})";
    }  
}