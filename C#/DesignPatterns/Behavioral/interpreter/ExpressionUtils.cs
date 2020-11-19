using System;

namespace interpreter
{
    public sealed class ExpressionUtils
    {
        public static bool IsOperator(string s)
        {
            return s switch
            {
                "+" => true,
                "-" => true,
                "*" => true,
                _ => false
            };
        }

        public static IExpression GetOperator(string s, IExpression left, IExpression right)
        {
           return (IsOperator(s)) ? left : right;
        }
    }
}