namespace AOC2022.Day6.TuningTrouble;

public class ElfDevice
{
    public string DataStream { get; private set; }

    public int FirstMarkerIndex { get; private set; }

    public ElfDevice(string initialDataStream)
    {
        this.DataStream = initialDataStream;
        this.FindFirstMarkerIndex();
    }

    private void FindFirstMarkerIndex()
    {
        this.FirstMarkerIndex = 0;

        char c1 = ' ';
        char c2 = ' ';
        char c3 = ' ';
        char c4 = ' ';

        int counter = 1;
        foreach (char c in this.DataStream)
        {
            c1 = c2;
            c2 = c3;
            c3 = c4;
            c4 = c;

            if (!c1.Equals(' ') &&
                !c2.Equals(' ') &&
                !c3.Equals(' ') &&
                !c4.Equals(' ') &&
                !c1.Equals(c2) && !c1.Equals(c3) && !c1.Equals(c4) &&
                !c2.Equals(c3) && !c2.Equals(c4) &&
                !c3.Equals(c4))
            {
                this.FirstMarkerIndex = counter;
                break;
            }

            counter++;
        }
    }
}
