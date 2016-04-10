using System.Linq.Expressions;

namespace DesignPatterns.OtherPatterns.Specification
{
    public class ParameterReplacer : ExpressionVisitor
    {
        private readonly ParameterExpression _parameter;


        private ParameterReplacer(ParameterExpression parameter)
        {
            _parameter = parameter;
        }


        public static Expression Replace(ParameterExpression parameter, Expression expression)
        {
            return new ParameterReplacer(parameter).Visit(expression);
        }


        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(_parameter);
        }
    }
}