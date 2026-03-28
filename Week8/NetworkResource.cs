namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    private FileStream _fs;
    public NetworkResource(string name) : base(name)
    {
        
    }
    public override void Open()
    {
        if (_fs == null)
        {
            _fs = new FileStream(Name, FileMode.Open);
            IsOpen = true;
        }
    }

    public override void Close()
    {
        if (_fs != null)
        {
            _fs.Close();
            _fs = null;
            IsOpen = false;
        }
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine("Diagnostic message");
    }
}