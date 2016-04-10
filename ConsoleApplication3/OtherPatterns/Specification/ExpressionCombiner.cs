using System;
using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public static class ExpressionCombiner
    {
        public static Expression<Func<T, bool>> Combine<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right, Func<Expression, Expression, Expression> merge)
        {
            var expression = merge(left.Body, right.Body);
            var parameter = Expression.Parameter(typeof (T));
            var expressionBody = ParameterReplacer.Replace(parameter, expression);

            return Expression.Lambda<Func<T, bool>>(expressionBody, parameter);
        }
    }
}