namespace DesignPatternsExample.Composite.CompositeAndStepBuilder
{
    public class LeafApartment: IComponentBuilding
    {
        private readonly string _name;
        private readonly int _floor;
        private readonly int _capacity;
        private readonly bool _isFurnished;

        public LeafApartment(string name, int floor, int capacity, bool isFurnished)
        {
            _name = name;
            _floor = floor;
            _capacity = capacity;
            _isFurnished = isFurnished;
        }
        public int Capacity()
        {
            return _capacity;
        }

        public bool IsFurnished()
        {
            return _isFurnished;
        }

        public void Add(IComponentBuilding building)
        {
            return;
        }

        public void Remove(IComponentBuilding building)
        {
            return;
        }
    }
}
