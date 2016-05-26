using DesignPatterns.BehaviorPatterns.Visitor.Visitors;

namespace DesignPatterns.BehaviorPatterns.Visitor.Element
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}