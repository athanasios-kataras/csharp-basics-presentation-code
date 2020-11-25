using System;

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Interfaces
{
    public interface ISampleInterface
    {
        // Methods
        void SampleMethod();

        // Properties
        int SampleInt {get; set;}

        // Indexer
        int this[int index] { get; set;}

        // Event
        event EventHandler SampleEvent;
    }
}
