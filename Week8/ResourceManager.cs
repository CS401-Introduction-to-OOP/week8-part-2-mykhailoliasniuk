namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private List<Resource> _resources = new List<Resource>();
    public void Add(T resource)
    {
        _resources.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var resource in _resources)
        {
            resource.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var resource in _resources)
        {
            if (resource.IsOpen == true)
            {
                resource.Close();
            }
        }
    }
    
}