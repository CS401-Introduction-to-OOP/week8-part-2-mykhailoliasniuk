namespace Week8;

public class DataContainer<T> where T : DataItem
{
    private List<DataItem> _items = new List<DataItem>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public int GetTotalSize()
    {
        int res = 0;
        foreach (var item in _items)
        {
            res += item.GetSize();
        }

        return res;
    }
}