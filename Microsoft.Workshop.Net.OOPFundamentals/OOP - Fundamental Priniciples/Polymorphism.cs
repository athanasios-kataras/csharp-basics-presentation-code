namespace Microsoft.Workshop.Net.OOPFundamentals
{
    using System;

    public class PolymorphicBase
    {
        public virtual void Override()
        {
            Console.WriteLine("PolymorphicBase");
        }
    }

    public class PolymorphicExtend: PolymorphicBase
    {
        public override void Override()
        {
            Console.WriteLine("PolymorphicExtend");
        }
    }

    public class PolymorphicExtendHide: PolymorphicBase
    {
        public new void Override()
        {
            Console.WriteLine("PolymorphicExtendHide");
        }
    }
}