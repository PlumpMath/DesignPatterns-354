namespace DesignPatterns.StructuralPattern.Flyweight.FlyweightAbstract
{
    public abstract class House
    {
        protected int Stages;

        public abstract void Build(double longitude, double latitude);
    }
}