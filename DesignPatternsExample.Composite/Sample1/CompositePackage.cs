namespace DesignPatternsExample.Composite.Sample1;

public class CompositePackage : IComponentPackage
{
    private List<IComponentPackage> _packages = new();
    public CompositePackage()
    {
            
    }
    public CompositePackage(List<IComponentPackage> components)
    {
        _packages.AddRange(components);
    }
    public int Size()
    {
        return _packages.Select(p => p.Size()).Sum();
    }

    public void Add(IComponentPackage package)
    {
        _packages.Add(package);
    }

    public void Remove(IComponentPackage package)
    {
        _packages.Remove(package);
    }
}