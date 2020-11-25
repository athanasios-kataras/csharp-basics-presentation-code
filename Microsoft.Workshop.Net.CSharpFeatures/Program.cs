using System;
using Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks;
using Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Interfaces;
using Microsoft.Workshop.Net.CSharpFeatures.OperatorExtentions;

namespace Microsoft.Workshop.Net.CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface with implementation testing
            // IFirstInterface multiInterfaceImpl = new MultiImplementation(); 
            // multiInterfaceImpl.DoSomething();
            // ISecondInterface multiInterfaceImpl2 = new MultiImplementation(); 
            // multiInterfaceImpl2.DoSomething();
            #endregion

            #region Anonymous type testing
            var anon = new AnonymousTypes();
            // anon.TestAnonymousTypeEquality();
            // What will this output if uncommented
            // anon.TestNonAnonymousTypeEquality();
            #endregion

            #region Dynamic type testing
            var dyn = new DynamicTypes();
            // dyn.CallDynamicNonExistent();
            // dyn.AssignWrongTypeToDynamic();
            //dyn.ShowCaseExpandoObject();
            #endregion

            #region Cached array
            // var bookArray = new BookCollection();
            // var book = bookArray["SN2131232"];
            // book = bookArray["SN2131232"];
            #endregion

            #region Operator overloading
            // var a = new Fraction(5, 4);
            // var b = new Fraction(1, 2);
            // Console.WriteLine(-a);   // output: -5 / 4
            // Console.WriteLine(a + b);  // output: 14 / 8
            // Console.WriteLine(a - b);  // output: 6 / 8
            // Console.WriteLine(a * b);  // output: 5 / 8
            // Console.WriteLine(a / b);  // output: 10 / 4
            #endregion

            #region Custom conversion operators
            var doubleFraction = new DoubleFraction() { Num = 1.12, Den = 2.12};
            var intFraction = new IntFraction() { Num = 1, Den = 2};

            IntFraction doubleToInt = (IntFraction)doubleFraction;
            DoubleFraction intToDouble = intFraction;

            Console.WriteLine("Double to int conversion num: " + doubleToInt.Num + " den:" + doubleToInt.Den);
            Console.WriteLine("Int to double conversion num: " + intToDouble.Num + " den:" + intToDouble.Den);
            #endregion
        }
    }
}
