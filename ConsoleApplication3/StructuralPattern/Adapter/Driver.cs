using DesignPatterns.StructuralPattern.Adapter.Target;

namespace DesignPatterns.StructuralPattern.Adapter
{
    public class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}