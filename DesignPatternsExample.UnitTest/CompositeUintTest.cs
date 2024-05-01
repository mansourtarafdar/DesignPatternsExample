using DesignPatternsExample.Composite.Sample1;

namespace DesignPatternsExample.UnitTest
{
    public class CompositeUintTest
    {
        [Fact]
        public void WhenIHavePackage_PackageSize_ShouldBeSumOfChildrenPackages()
        {
            IComponentPackage box1 = new CompositePackage();
            box1.Add(new LeafProduct("Pen",10));
            IComponentPackage box2 = new CompositePackage(
                new List<IComponentPackage>()
                { 
                    new LeafProduct("Paper", 20), 
                    new LeafProduct("pencil", 30)
                });
            box1.Add(box2);
            var box3 = new CompositePackage();
            box3.Add(new LeafProduct("Laptop", 49));
            box3.Add(new LeafProduct("Cable", 80));
            box2.Add(box3);

            Assert.Equal(box1.Size(),189);
        }
    }
}