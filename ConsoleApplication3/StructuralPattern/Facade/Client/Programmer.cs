using DesignPatterns.StructuralPattern.Facade.CustomFacade;

namespace DesignPatterns.StructuralPattern.Facade.Client
{
    public class Programmer
    {
        public Programmer(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}