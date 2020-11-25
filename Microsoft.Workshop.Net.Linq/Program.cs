using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Workshop.Net.Linq.Basics;
using Microsoft.Workshop.Net.Linq.Linq_Syntax;

namespace Microsoft.Workshop.Net.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enumerable
            // EnumerableCollection<int> example = new EnumerableCollection<int>();
            // example.Where((x) => x == 1).ToList();
            #endregion

            #region Custom Enumerable
            // SumCollection sumCollection = new SumCollection(new int[] { 1, 2, 3, 4, 5 });
            // foreach (int value in sumCollection)
            // {
            //     Console.WriteLine(value);
            // }
            // Console.WriteLine(sumCollection.ToList().Count());
            #endregion

            #region Custom Enumerable yield
            // SumCollectionYield sumCollectionYield = new SumCollectionYield(new int[] { 1, 2, 3, 4, 5 });
            // foreach (int value in sumCollectionYield)
            // {
            //     Console.WriteLine(value);
            // }

            #endregion

            #region Yield example
            // Console.WriteLine("Has 32:" + Power(2,8).Where(x => x == 32).Any());
            #endregion

            #region Query Syntax
            var qsExample = new QuerySyntaxExample();
            // qsExample.SelectAsNewType();
            // qsExample.GroupBy();
            // qsExample.GroupByPrice();
            qsExample.ExecuteOrderingExamples();
            #endregion 

            #region Join Syntax
            var qsExample2 = new QuerySyntaxExample();
            // qsExample2.ExecuteInnerJoin();
            // qsExample2.ExecuteGroupJoin();
            // qsExample2.ExecuteGroupJoinWithClass();
            // qsExample2.ExecuteLeftOuterJoin();
            #endregion 

            #region Method Extentions
            var msExample = new MethodSyntaxExample();
            // msExample.ExecuteAggregateExample();
            #endregion

            #region Expression Tree
            var exprTreeExample = new ExpressionTrees();
            // exprTreeExample.StartExpressionTreeExample();
            exprTreeExample.InterpretExpressionTreeExample();
            #endregion
        }

        #region Yield example
        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
        #endregion
    }
}
