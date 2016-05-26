using System;
using DesignPatterns.BehaviorPatterns.Visitor.Element;

namespace DesignPatterns.BehaviorPatterns.Visitor.Visitors
{
    public class HtmlVisitor : IVisitor
    {
        public void VisitPerson(Person person)
        {
            var html = string.Format("<HTML>{0}, {1}</HTML>", person.Name, person.Age);
            Console.WriteLine(html);
        }

        public void VisitCompany(Company company)
        {
            var html = string.Format("<XML>{0}, {1}, {2}</XML>", company.Name, company.AccNumber, company.FoundationYear);
            Console.WriteLine(html);
        }
    }
}