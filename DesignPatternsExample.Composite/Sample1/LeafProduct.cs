namespace DesignPatternsExample.Composite.Sample1;

public class LeafProduct : IComponentPackage
{
    private readonly string _name;
    private readonly int _size;

    public LeafProduct(string name,int size)
    {
        _name = name;
        _size = size;
    }
    public int Size()
    {
        return _size;
    }

    public void Add(IComponentPackage package)
    {
        return;
    }

    public void Remove(IComponentPackage package)
    {
        return;
    }
}