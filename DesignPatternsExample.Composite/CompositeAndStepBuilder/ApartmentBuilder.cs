namespace DesignPatternsExample.Composite.CompositeAndStepBuilder;

public class ApartmentBuilder
{
    public ApartmentBuilder()
    {
        
    }
    public ApartmentBuilder(string expression)
    {
        string[] values = expression.Split(',');
        _name = values[0];
        _floor = Convert.ToInt32(values[1]);
        _capacity = Convert.ToInt32(values[2]);
        _isFurnished = Convert.ToBoolean(values[3]);
    }
    private string _name;
    private int _floor;
    private int _capacity;
    private bool _isFurnished;

    public ApartmentBuilder AddName(string name)
    {
        _name = name;
        return this;
    }
    public ApartmentBuilder AddFloor(int floor)
    {
        _floor = floor;
        return this;
    }

    public ApartmentBuilder AddCapacity(int capacity)
    {
        _capacity = capacity;
        return this;
    }

    public ApartmentBuilder SetFurnished(bool isFurnished)
    {
        _isFurnished = isFurnished;
        return this;
    }

    public LeafApartment Build()
    {
        return new LeafApartment(_name, _floor, _capacity, _isFurnished);
    }
}