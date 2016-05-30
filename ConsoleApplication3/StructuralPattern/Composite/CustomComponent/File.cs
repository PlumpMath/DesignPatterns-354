namespace DesignPatterns.StructuralPattern.Composite.CustomComponent
{
    public class File : Component
    {
        public File(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new System.NotImplementedException();
        }
    }
}