namespace DesignPatterns.CreationalPatterns.Builder.Builder
{
    public class HomeBreadBuilder : BreadBuilder
    {
        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour {Sort = "Высший"};
        }

        public override void SetAdditives()
        {
            
        }
    }
}