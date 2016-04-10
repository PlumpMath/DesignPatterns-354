using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public class ExpressionSpecification<T> : Specification<T>
    {
        public ExpressionSpecification(Expression<Func<T, bool>> predicate) : base(predicate)
        {
        }
    }
}