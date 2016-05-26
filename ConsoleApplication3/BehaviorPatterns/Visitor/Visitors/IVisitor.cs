using DesignPatterns.BehaviorPatterns.Visitor.Element;

namespace DesignPatterns.BehaviorPatterns.Visitor.Visitors
{
    public interface IVisitor
    {
        void VisitPerson(Person person);

        void VisitCompany(Company company);
    }
}