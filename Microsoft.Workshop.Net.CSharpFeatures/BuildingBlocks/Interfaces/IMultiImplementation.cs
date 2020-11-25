namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Interfaces
{
    public interface IFirstInterface
    {
        void DoSomething() {
            System.Console.WriteLine("One");
        }
    }

    public interface ISecondInterface
    {
        void DoSomething() {
            System.Console.WriteLine("Two");
        }
    }

    public class MultiImplementation : IFirstInterface, ISecondInterface
    {

    }
}