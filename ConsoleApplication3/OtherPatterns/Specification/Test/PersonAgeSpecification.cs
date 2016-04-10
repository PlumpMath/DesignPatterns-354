namespace DesignPatterns.OtherPatterns.Specification.Test
{
    public class PersonAgeSpecification : Specification<Person>
    {
        public PersonAgeSpecification(int age) : base(x => x.Age > age)
        {
        }
    }
}