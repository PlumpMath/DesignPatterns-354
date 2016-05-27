using System;
using DesignPatterns.BehaviorPatterns.Visitor.Element;

namespace DesignPatterns.BehaviorPatterns.Visitor.Visitors
{
    public class XmlVisitor : IVisitor
    {
        public string Output { get; private set; }

        public void VisitPerson(Person person)
        {
            var xml = string.Format("<XML>{0}, {1}</XML>", person.Name, person.Age);
            Console.WriteLine(xml);
        }

        public void VisitCompany(Company company)
        {
            var xml = string.Format("<XML>{0}, {1}, {2}</XML>", company.Name, company.AccNumber, company.FoundationYear);
            Console.WriteLine(xml);
        }
    }
}