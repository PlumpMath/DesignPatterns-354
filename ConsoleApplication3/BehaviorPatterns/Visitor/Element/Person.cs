using DesignPatterns.BehaviorPatterns.Visitor.Visitors;

namespace DesignPatterns.BehaviorPatterns.Visitor.Element
{
    public class Person : IAccount
    {
        public string Name { get; private set; }
        public int Age { get; private set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public void Accept(IVisitor visitor)
        {
            visitor.VisitPerson(this);
        }
    }
}