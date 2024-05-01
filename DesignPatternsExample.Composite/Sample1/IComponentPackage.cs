namespace DesignPatternsExample.Composite.Sample1
{
    public interface IComponentPackage
    {
        int Size();
        void Add(IComponentPackage package);
        void Remove(IComponentPackage package);
    }
}
