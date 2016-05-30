using DesignPatterns.StructuralPattern.Facade.SubSystem;

namespace DesignPatterns.StructuralPattern.Facade.CustomFacade
{
    public class VisualStudioFacade
    {
        private readonly TestEditor _textEditor;
        private readonly Compiler _compiler;
        private readonly Clr _clr;


        public VisualStudioFacade(TestEditor textEditor, Compiler compiler, Clr clr)
        {
            _textEditor = textEditor;
            _compiler = compiler;
            _clr = clr;
        }


        public void Start()
        {
            _textEditor.WriteText();
            _textEditor.SaveText();
            _compiler.Compile();
            _clr.Execute();
        }

        public void Stop()
        {
            _clr.Finish();
        }
    }
}