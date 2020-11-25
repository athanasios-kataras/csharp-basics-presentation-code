using System;
using System.Text;
using System.Linq;
using Microsoft.Workshop.Net.Functional.Declarative;

namespace Microsoft.Workshop.Net.Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pure Functions
            // var sb = new StringBuilder();
            // Console.WriteLine(PureFunctions.Concat(sb, "one").ToString());
            // Console.WriteLine(PureFunctions.Concat(sb, "one").ToString());
            // var sb2 = new StringBuilder();
            // Console.WriteLine(PureFunctions.ConcatPure(sb2, "one").ToString());
            // Console.WriteLine(PureFunctions.ConcatPure(sb2, "one").ToString());
            #endregion

            #region Delegates
            // var delExample = new DelegateExample();
            // PrintDelegate del = delExample.PrintMessage;
            // del("Printing through message");
            // delExample.AddDelegate(del);
            // delExample.printDelegates[0]("Printing through collection");
            // // Using the return value
            // delExample.GetDelegate(0)("Printing through return value");
            #endregion

            #region Multicast Delegates
            // var combDelExample = new CombinedDelegates();
            // combDelExample.RegisterToPrintEvent(x => Console.WriteLine("1st delegate:" + x));
            // combDelExample.RegisterToPrintEvent(x => Console.WriteLine("2nd delegate:" + x));
            // combDelExample.RaiseEvent("Combined delegate message");
            #endregion

            #region Func Delegates
            // Func<int, int> addOne = n => n + 1;
            // Func<int, int, int> addNums = (x, y) => x + y;
            // Func<int, bool> isZero = n => n == 0;

            // Console.WriteLine(addOne(5)); // 6
            // Console.WriteLine(isZero(addNums(-5, 5))); // True

            // int[] a = { 0, 1, 0, 3, 4, 0 };
            // Console.WriteLine(a.Count(isZero)); // 3
            #endregion
        
            #region Predicate Delegates
            // var funcDelegate = new FuncDelegates();
            // funcDelegate.DoWork();

            // var predDelegate = new PredicateDelegates();
            // predDelegate.DoWork();
            #endregion

            #region Anonymous Function
            Func<int, int, int> sum = delegate (int a, int b) { return a + b; };
            Console.WriteLine(sum(3, 4));  // output: 7
            #endregion
        }
    }
}
