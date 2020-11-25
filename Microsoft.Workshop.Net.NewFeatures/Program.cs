using System;
using System.Dynamic;
using Microsoft.Workshop.Net.NewFeatures.NewFeatures;

namespace Microsoft.Workshop.Net.NewFeatures
{
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            #region TupleExample
            var tuplesExample = new Tuples();
            if (tuplesExample.GetOldTuple() == tuplesExample.GetOldTuple())
            {
                Console.WriteLine("Old tuples match");
            }

            if (tuplesExample.GetNewTuple() == tuplesExample.GetNewTuple())
            {
                Console.WriteLine("New tuples match");
            }
            #endregion

            #region Tuple Deconstructor
            var tuple = ("This is a tuple with value:", 1);
            Console.WriteLine(tuple.Item1 + tuple.Item2);

            var (text, value) = tuple;
            Console.WriteLine(text + value);
            #endregion

            #region Pattern Matching
            var emp1 = new Employee() { Name = "Thanos" };
            var emp2 = new Employee() { Name = "Thanos" };
            // dynamic noeemp2 = new ExpandoObject();
            // noeemp2.Name = "Thanos";
            // Console.WriteLine("emp1 equals emp2:" + (emp1.CompareTo(emp2)));
            // Console.WriteLine("emp1 equals emp2:" + (emp1.CompareTo(noeemp2)));

            // switch(emp1) {
            //     case Manager manager when manager.Rank > 2:
            //     Console.WriteLine("Senior manager");
            //     break;
            //     case Manager manager when manager.Rank <= 2:
            //     Console.WriteLine("Assosciate manager");
            //     break;
            //     default:
            //     Console.WriteLine("Simple employee");
            //     break;
            // }
            #endregion

            #region Indices and ranges
            var indicesExample = new IndicesAndRanges();
            indicesExample.PrintFromLast(1);
            indicesExample.PrintRange(1, 7);
            indicesExample.PrintReverseRange(1, 7);
            #endregion

            #region Null Coallescing
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
            #endregion

            string type = null;
            Console.WriteLine("Type:" + type);
        }
    }
}
