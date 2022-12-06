namespace AOC2022.Day6.TuningTrouble;

public class ElfDevice
{
    public string DataStream { get; private set; }

    public int FirstPacketMarkerIndex { get; private set; }
    public int FirstMessageMarkerIndex { get; private set; }

    public ElfDevice(string initialDataStream)
    {
        this.DataStream = initialDataStream;
        this.FindFirstPacketMarkerIndex();
        this.FindFirstMessageMarkerIndex();
    }

    private void FindFirstPacketMarkerIndex()
    {
        this.FirstPacketMarkerIndex = 0;

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
                this.FirstPacketMarkerIndex = counter;
                break;
            }

            counter++;
        }
    }

    private void FindFirstMessageMarkerIndex()
    {
        // This is a burte force approach ... there are better ways ... 

        this.FirstMessageMarkerIndex = 0;

        char c1 = ' ';
        char c2 = ' ';
        char c3 = ' ';
        char c4 = ' ';
        char c5 = ' ';
        char c6 = ' ';
        char c7 = ' ';
        char c8 = ' ';
        char c9 = ' ';
        char c10 = ' ';
        char c11 = ' ';
        char c12 = ' ';
        char c13 = ' ';
        char c14 = ' ';

        int counter = 1;
        foreach (char c in this.DataStream)
        {
            c1 = c2;
            c2 = c3;
            c3 = c4;
            c4 = c5;
            c5 = c6;
            c6 = c7;
            c7 = c8;
            c8 = c9;
            c9 = c10;
            c10 = c11;
            c11 = c12;
            c12 = c13;
            c13 = c14;
            c14 = c;

            if (!c1.Equals(' ') &&
                !c2.Equals(' ') &&
                !c3.Equals(' ') &&
                !c4.Equals(' ') &&
                !c5.Equals(' ') &&
                !c6.Equals(' ') &&
                !c7.Equals(' ') &&
                !c8.Equals(' ') &&
                !c9.Equals(' ') &&
                !c10.Equals(' ') &&
                !c11.Equals(' ') &&
                !c12.Equals(' ') &&
                !c13.Equals(' ') &&
                !c14.Equals(' ') &&
                !c1.Equals(c2) && !c1.Equals(c3) && !c1.Equals(c4) && !c1.Equals(c5) && !c1.Equals(c6) && !c1.Equals(c7) && !c1.Equals(c8) && !c1.Equals(c9) && !c1.Equals(c10) && !c1.Equals(c11) && !c1.Equals(c12) && !c1.Equals(c13) && !c1.Equals(c14) &&
                !c2.Equals(c3) && !c2.Equals(c4) && !c2.Equals(c5) && !c2.Equals(c6) && !c2.Equals(c7) && !c2.Equals(c8) && !c2.Equals(c9) && !c2.Equals(c10) && !c2.Equals(c11) && !c2.Equals(c12) && !c2.Equals(c13) && !c2.Equals(c14) && 
                !c3.Equals(c4) && !c3.Equals(c5) && !c3.Equals(c6) && !c3.Equals(c7) && !c3.Equals(c8) && !c3.Equals(c9) && !c3.Equals(c10) && !c3.Equals(c11) && !c3.Equals(c12) && !c3.Equals(c13) && !c3.Equals(c14) &&
                !c4.Equals(c5) && !c4.Equals(c6) && !c4.Equals(c7) && !c4.Equals(c8) && !c4.Equals(c9) && !c4.Equals(c7) && !c4.Equals(c8) && !c4.Equals(c9) && !c4.Equals(c10) && !c4.Equals(c11) &&
                !c5.Equals(c6) && !c5.Equals(c7) && !c5.Equals(c8) && !c5.Equals(c9) && !c5.Equals(c10) && !c5.Equals(c11) && !c5.Equals(c12) && !c5.Equals(c13) && !c5.Equals(c14) &&
                !c6.Equals(c7) && !c6.Equals(c8) && !c6.Equals(c9) && !c6.Equals(c10) && !c6.Equals(c11) && !c6.Equals(c12) && !c6.Equals(c13) && !c6.Equals(c14) &&
                !c7.Equals(c8) && !c7.Equals(c9) && !c7.Equals(c10) && !c7.Equals(c11) && !c7.Equals(c12) && !c7.Equals(c13) && !c7.Equals(c14) &&
                !c8.Equals(c9) && !c8.Equals(c10) && !c8.Equals(c11) && !c8.Equals(c12) && !c8.Equals(c13) && !c8.Equals(c14) &&
                !c9.Equals(c10) && !c9.Equals(c3) && !c9.Equals(c12) && !c9.Equals(c13) && !c9.Equals(c14) &&
                !c10.Equals(c11) && !c10.Equals(c12) && !c10.Equals(c13) && !c10.Equals(c14) &&
                !c11.Equals(c12) && !c11.Equals(c13) && !c11.Equals(c14) &&
                !c12.Equals(c13) && !c12.Equals(c14) &&
                !c13.Equals(c14) 
                )
            {
                this.FirstMessageMarkerIndex = counter;
                break;
            }

            counter++;
        }
    }
}
