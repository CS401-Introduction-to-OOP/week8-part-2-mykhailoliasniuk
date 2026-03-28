
using Week8;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var Manager = new ResourceManager<Resource>();
        Manager.Add(network);
        Manager.Add(file);
        Manager.OpenAll();
        using (var res = new FileResource("file"))
        {
            res.Open();
        }
    }
    
}