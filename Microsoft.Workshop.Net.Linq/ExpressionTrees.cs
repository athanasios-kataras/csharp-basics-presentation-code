using System;
using System.Linq.Expressions;

namespace Microsoft.Workshop.Net.Linq
{
    public class ExpressionTrees
    {
        public void StartExpressionTreeExample()
        {
            Expression<Func<int, bool>> lambda = num => num < 5;

            // Decompose the expression tree.  
            ParameterExpression param = (ParameterExpression)lambda.Parameters[0];
            BinaryExpression operation = (BinaryExpression)lambda.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}",
                  param.Name, left.Name, operation.NodeType, right.Value);
        }

        public void InterpretExpressionTreeExample()
        {
            Expression<Func<int, int, int>> addition = (a, b) => a - b;

            Console.WriteLine($"This expression is a {addition.NodeType} expression type");
            Console.WriteLine($"The name of the lambda is {((addition.Name == null) ? "<null>" : addition.Name)}");
            Console.WriteLine($"The return type is {addition.ReturnType.ToString()}");
            Console.WriteLine($"The expression has {addition.Parameters.Count} arguments. They are:");
            foreach (var argumentExpression in addition.Parameters)
            {
                Console.WriteLine($"\tParameter Type: {argumentExpression.Type.ToString()}, Name: {argumentExpression.Name}");
            }

            var additionBody = (BinaryExpression)addition.Body;
            Console.WriteLine($"The body is a {additionBody.NodeType} expression");
            Console.WriteLine($"The left side is a {additionBody.Left.NodeType} expression");
            var left = (ParameterExpression)additionBody.Left;
            Console.WriteLine($"\tParameter Type: {left.Type.ToString()}, Name: {left.Name}");
            Console.WriteLine($"The right side is a {additionBody.Right.NodeType} expression");
            var right = (ParameterExpression)additionBody.Right;
            Console.WriteLine($"\tParameter Type: {right.Type.ToString()}, Name: {right.Name}");
        }
    }
}