namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Interfaces
{
    public interface IAdvancedInterface
    {
        // Static members
        static int Counter { get; set; }
        static NestedClass NestedClassObject {get; set;}

        // Static constructor
        static IAdvancedInterface()
        {
            Counter = 0;
        }
        // Constants
        const int SampleConstant = 1;

        // Operators
        public static IAdvancedInterface operator +(IAdvancedInterface a)
        {
            return a;
        }

        // Nested types
        class NestedClass {
        }

        // Explicit access modifiers 
        internal void InternalSampleMethod();

        // What's the point of this?
        // private void InternalSampleMethod();

        // What will happen if I uncomment this:
        // private void WithBody() {
        //
        // }
    }
}