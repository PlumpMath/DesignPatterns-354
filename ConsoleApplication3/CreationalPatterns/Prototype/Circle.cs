namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class Circle : Shape
    {
        private readonly int _dia;

        public Circle(int dia)
        {
            _dia = dia;
        }

        public override string GetInfo()
        {
            return string.Format("Circle - DIA={0}", _dia);
        }
    }
}