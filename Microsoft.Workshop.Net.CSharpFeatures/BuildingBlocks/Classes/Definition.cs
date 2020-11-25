namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Classes
{
    using System;
    public class Person
    {

        Person p = new Person();

        public Person()
        {
            Person p2 = p;
        }

    }

    public class Example<T>
    {
        // Field
        private int exampleField;

        // Constants
        private const int ExampleConstant = 1;

        // Properties
        private int ExampleProperty { get; set; }

        // Method
        private int ExampleMethod() { return 1; }

        // Constructor
        public Example() { }

        // Event
        event EventHandler SampleEvent;

        // Finalizer
        ~Example() { }

        // Indexer
        private T[] arr = new T[100];

        // Operator
        public static Example<T> operator /(Example<T> a, Example<T> b)
        {
            return new Example<T>() { ExampleProperty = a.ExampleProperty / b.ExampleProperty };
        }
    }

    public class Container
    {
        class Nested
        {
            Nested() { }
        }
    }
}