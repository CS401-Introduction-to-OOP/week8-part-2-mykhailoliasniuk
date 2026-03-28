namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
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