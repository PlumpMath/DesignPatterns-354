using DesignPatterns.StructuralPattern.Adapter.Adaptee;
using DesignPatterns.StructuralPattern.Adapter.CustomAdapter;
using DesignPatterns.StructuralPattern.Adapter.Target;

namespace DesignPatterns.StructuralPattern.Adapter
{
    public class AdapterTest : PatternTest
    {
        public AdapterTest() : base("Adapter")
        {
        }


        public override void Run()
        {
            var driver = new Driver();
            var car = new Car();

            driver.Travel(car);

            var camel = new Camel();
            var adapter = new AnimalTransportAdapter(camel);

            driver.Travel(adapter);
        }
    }
}