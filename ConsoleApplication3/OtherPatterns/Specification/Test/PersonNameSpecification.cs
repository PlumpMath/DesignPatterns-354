namespace DesignPatterns.OtherPatterns.Specification.Test
{
    public class PersonNameSpecification : Specification<Person>
    {
        public PersonNameSpecification(string name)
            : base(x => x.Name == name)
        {
        }
    }
}