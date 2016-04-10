using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public class OrSpecification<T> : Specification<T>
    {
        public OrSpecification(ISpecification<T> left, ISpecification<T> right) : base(CreateOrPredicate(left, right))
        {

        }

        private static Expression<Func<T, bool>> CreateOrPredicate(ISpecification<T> left, ISpecification<T> right)
        {
            return ExpressionCombiner.Combine(left.Predicate, right.Predicate, Expression.OrElse);
        }
    }
}