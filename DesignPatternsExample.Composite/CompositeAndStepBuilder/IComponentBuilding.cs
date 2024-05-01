namespace DesignPatternsExample.Composite.CompositeAndStepBuilder;

public interface IComponentBuilding
{
    int Capacity();
    void Add(IComponentBuilding building);
    void Remove(IComponentBuilding building);
    bool IsFurnished();
}