namespace DesignPatterns.CreationalPatterns.Builder.Builder
{
    public class ManufactoryBreadBuilder : BreadBuilder
    {
        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour {Sort = "Первый сорт"};
        }

        public override void SetAdditives()
        {
            Bread.Additives = new Additives {Name = "Специи"};
        }
    }
}