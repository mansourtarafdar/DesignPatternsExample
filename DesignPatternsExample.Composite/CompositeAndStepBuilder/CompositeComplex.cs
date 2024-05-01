namespace DesignPatternsExample.Composite.CompositeAndStepBuilder
{
    public class CompositeComplex : IComponentBuilding
    {
        private List<IComponentBuilding> _buildings = new();
        public int Capacity()
        {
            return _buildings.Sum(b => b.Capacity());
        }

        public void Add(IComponentBuilding building)
        {
            _buildings.Add(building);
        }

        public void Remove(IComponentBuilding building)
        {
            _buildings.Remove(building);
        }

        public bool IsFurnished()
        {
            return _buildings.TrueForAll(b => b.IsFurnished());
        }
    }
}
