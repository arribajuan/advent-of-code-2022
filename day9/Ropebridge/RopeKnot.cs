namespace AOC2022.Day9.Ropebridge;

public class RopeKnot
{
    public int KnotNumber { get; set; }
    public bool IsHead { get; set; }
    public bool IsTail { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        string headOrTail = "";
        if (IsHead)
        {
            headOrTail += "Head ";
        }
        if (IsTail)
        {
            headOrTail += "Tail ";
        }
        
        return $"Knot {KnotNumber} ({X},{Y}) {headOrTail}";
    }
}