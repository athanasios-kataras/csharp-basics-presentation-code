namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces
{
    using System;
    public class WithUsingDirective
    {
        public void Write() {
            Console.WriteLine("Hello World!");
        }
    }
}

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces
{
    public class WithoutUsingDirective
    {
        public void Write() {
            System.Console.WriteLine("Hello World!");
        }
    }
}

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces
{
    using static System.Console;
    public class WithUsingStaticDirective
    {
        public void Write() {
            WriteLine("Hello World!");
        }
    }
}

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces
{
    public class WithoutUsingStaticDirective
    {
        public void Write() {
            System.Console.WriteLine("Hello World!");
        }
    }
}

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces
{
    using SystemMath = System.Math;
    using CustomMath = Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces.Math;
    public class UsingDirectiveWithAlias
    {
        public void Write() {
            double a = 1, b = 2;
            SystemMath.Pow(a, b);
            CustomMath.Pow(a, b);
        }
    }
}

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Namespaces
{
    public class Math
    {
        public static double Pow(double a, double b) {
            return System.Math.Pow(a,b);
        }
    }
}