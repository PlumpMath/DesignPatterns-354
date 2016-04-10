using System;
using System.Linq;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public class NotSpecification<T> : Specification<T>
    {
        public NotSpecification(ISpecification<T> specification) : base(CreateNotPredicate(specification))
        {

        }

        private static Expression<Func<T, bool>> CreateNotPredicate(ISpecification<T> specification)
        {
            return Expression.Lambda<Func<T, bool>>(specification.Predicate, specification.Predicate.Parameters.Single());
        }
    }
}