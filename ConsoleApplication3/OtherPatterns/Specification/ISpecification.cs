using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Predicate { get; }

        bool IsSatisfiedBy(T o);

        ISpecification<T> And(ISpecification<T> specification);

        ISpecification<T> Or(ISpecification<T> specification);

        ISpecification<T> Not(ISpecification<T> specification);
    }
}