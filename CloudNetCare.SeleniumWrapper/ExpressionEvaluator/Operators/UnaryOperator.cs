using System;
using System.Linq.Expressions;

namespace CloudNetCare.SeleniumWrapper.ExpressionEvaluator.Operators
{
    internal class UnaryOperator : Operator<Func<Expression, UnaryExpression>>
    {
        public UnaryOperator(string value, int precedence, bool leftassoc, Func<Expression, UnaryExpression> func, ExpressionType expressionType)
            : base(value, precedence, leftassoc, func, expressionType)
        {
            Arguments = 1;
        }
    }
}