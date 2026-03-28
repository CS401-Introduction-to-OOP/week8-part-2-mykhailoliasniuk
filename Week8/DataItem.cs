namespace Week8;

public class DataItem
{
    public string Id { get; set; }
    public byte[] Pyload { get; set; }

    public int GetSize()
    {
        return Pyload.Length;
    }
}