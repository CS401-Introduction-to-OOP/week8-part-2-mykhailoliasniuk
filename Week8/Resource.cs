namespace Week8;

public abstract class Resource
{
    public string Name;
    public bool IsOpen;

    protected Resource(string name)
    {
        Name = name;
        IsOpen = false;
    }
    public abstract void Open();
    public abstract void Close();
}