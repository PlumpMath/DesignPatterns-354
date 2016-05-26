using DesignPatterns.BehaviorPatterns.Visitor.Visitors;

namespace DesignPatterns.BehaviorPatterns.Visitor.Element
{
    public class Company : IAccount
    {
        public string Name { get; private set; }
        public string AccNumber { get; private set; }
        public int FoundationYear { get; private set; }


        public Company(string name, string accNumber, int foundationYear)
        {
            Name = name;
            AccNumber = accNumber;
            FoundationYear = foundationYear;
        }


        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompany(this);
        }
    }
}