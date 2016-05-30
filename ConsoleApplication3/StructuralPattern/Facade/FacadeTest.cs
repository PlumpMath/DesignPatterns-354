using DesignPatterns.StructuralPattern.Facade.Client;
using DesignPatterns.StructuralPattern.Facade.CustomFacade;
using DesignPatterns.StructuralPattern.Facade.SubSystem;

namespace DesignPatterns.StructuralPattern.Facade
{
    public class FacadeTest : PatternTest
    {
        public FacadeTest() : base("Facade")
        {
        }


        public override void Run()
        {
            var textEditor = new TestEditor();
            var clr = new Clr();
            var compiler = new Compiler();

            var ide = new VisualStudioFacade(textEditor, compiler, clr);

            var programmer = new Programmer(ide);
        }
    }
}