namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
        
    }
    public override void Open()
    {
        throw new NotImplementedException();
    }

    public override void Close()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        Close();
    }
}