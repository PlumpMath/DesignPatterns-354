using DesignPatterns.StructuralPattern.Adapter.Adaptee;
using DesignPatterns.StructuralPattern.Adapter.Target;

namespace DesignPatterns.StructuralPattern.Adapter.CustomAdapter
{
    public class AnimalTransportAdapter : ITransport
    {
        private readonly IAnimal _animal;


        public AnimalTransportAdapter(IAnimal animal)
        {
            _animal = animal;
        }


        public void Drive()
        {
            _animal.Move();
        }
    }
}