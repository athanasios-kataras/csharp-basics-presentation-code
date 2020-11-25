using System;

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks.Classes
{
    public partial class PatrialExample
    {
        public void DoSomething() {
            int value = 0;
            this.GetValue(ref value);
        }

        partial void GetValue(ref int value);
    }

    public partial class PatrialExample
    {
        partial void GetValue(ref int value) {
            value = 1;
        }
    }
}