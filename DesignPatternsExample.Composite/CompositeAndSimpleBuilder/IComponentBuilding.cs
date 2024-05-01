namespace DesignPatternsExample.Composite.CompositeAndSimpleBuilder;

public interface IComponentBuilding
{
    int Capacity();
    void Add(IComponentBuilding building);
    void Remove(IComponentBuilding building);
    bool IsFurnished();
}