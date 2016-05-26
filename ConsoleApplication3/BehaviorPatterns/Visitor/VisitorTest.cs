using DesignPatterns.BehaviorPatterns.Visitor.Element;
using DesignPatterns.BehaviorPatterns.Visitor.Visitors;
using Bank = DesignPatterns.BehaviorPatterns.Visitor.ObjectStructure.Bank;

namespace DesignPatterns.BehaviorPatterns.Visitor
{
    public class VisitorTest : PatternTest
    {
        public VisitorTest() : base("Visitor")
        {
        }


        public override void Run()
        {
            var bank = new Bank();

            var person1 = new Person("Person_1", 20);
            var company1 = new Company("Company_1", "123456", 1990);
            var person2 = new Person("Person_2", 30);

            var xmlVisitor = new XmlVisitor();
            var htmlVisitor = new HtmlVisitor();

            bank.AddAccount(person1);
            bank.AddAccount(company1);

            bank.Accept(xmlVisitor);
            bank.Accept(htmlVisitor);

            person2.Accept(xmlVisitor);
            person2.Accept(htmlVisitor);
        }
    }
}