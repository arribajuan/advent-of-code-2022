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

    }
}
