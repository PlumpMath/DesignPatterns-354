using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Predicate { get; private set; }


        protected Specification(Expression<Func<T, bool>> predicate)
        {
            Predicate = predicate;
        }


        public bool IsSatisfiedBy(T o)
        {
            var func = Predicate.Compile();
            return func(o);
        }

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }

        public ISpecification<T> Not(ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }
    }
}