using DesignPatterns.CreationalPatterns.Builder.Product;

namespace DesignPatterns.CreationalPatterns.Builder.Builder
{
    public abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }

        protected BreadBuilder()
        {
            Bread = new Bread();
        }

        public abstract void SetSalt();

        public abstract void SetFlour();

        public abstract void SetAdditives();
    }
}