using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public class AndSpecification<T> : Specification<T>
    {
        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
            : base(CreateAndPredicate(left, right))
        {

        }

        private static Expression<Func<T, bool>> CreateAndPredicate(ISpecification<T> left, ISpecification<T> right)
        {
            return ExpressionCombiner.Combine(left.Predicate, right.Predicate, Expression.AndAlso);
        }
    }
}