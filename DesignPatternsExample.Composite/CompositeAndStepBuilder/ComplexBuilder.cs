namespace DesignPatternsExample.Composite.CompositeAndStepBuilder;

public class ComplexBuilder
{
    private CompositeComplex _complex = new();

    public ComplexBuilder AddBuilding(IComponentBuilding building)
    {
        _complex.Add(building);
        return this;
    }
    public CompositeComplex Build()
    {
        return _complex;
    }
}