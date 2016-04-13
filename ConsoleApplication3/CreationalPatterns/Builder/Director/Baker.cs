using DesignPatterns.CreationalPatterns.Builder.Builder;

namespace DesignPatterns.CreationalPatterns.Builder.Director
{
    public class Baker
    {
        private readonly BreadBuilder _builder;


        public Baker(BreadBuilder builder)
        {
            _builder = builder;
        }


        public void Bake()
        {
            _builder.SetSalt();
            _builder.SetFlour();
            _builder.SetAdditives();
        }
    }
}