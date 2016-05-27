using System;
using DesignPatterns.BehaviorPatterns.Visitor.Element;

namespace DesignPatterns.BehaviorPatterns.Visitor.Visitors
{
    public class HtmlVisitor : IVisitor
    {
        public void VisitPerson(Person person)
        {
            var xml = string.Format("<HTML>{0}, {1}</HTML>", person.Name, person.Age);
            Console.WriteLine(xml);
        }

        public void VisitCompany(Company company)
        {
            var html = string.Format("<HTML>{0}, {1}, {2}</HTML>", company.Name, company.AccNumber, company.FoundationYear);
            Console.WriteLine(html);
        }
    }
}