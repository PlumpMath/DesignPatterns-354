using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Predicate { get; private set; }
        private readonly Lazy<Func<T, bool>> _lazyCompiledPredicate;

        private Func<T, bool> CompiledPredicate
        {
            get
            {
                return _lazyCompiledPredicate.Value;
            }
        }


        protected Specification(Expression<Func<T, bool>> predicate)
        {
            Predicate = predicate;
            _lazyCompiledPredicate = new Lazy<Func<T, bool>>(predicate.Compile);
        }


        public bool IsSatisfiedBy(T o)
        {
            return CompiledPredicate(o);
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