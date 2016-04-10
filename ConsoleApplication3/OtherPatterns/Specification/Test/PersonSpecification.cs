namespace DesignPatterns.OtherPatterns.Specification.Test
{
    public class PersonSpecification
    {
        public static ISpecification<Person> GetByName(string name)
        {
            return new ExpressionSpecification<Person>(x => x.Name == name);
        }

        public static ISpecification<Person> GetByAge(int age)
        {
            return new ExpressionSpecification<Person>(x => x.Age > age);
        }
    }
}