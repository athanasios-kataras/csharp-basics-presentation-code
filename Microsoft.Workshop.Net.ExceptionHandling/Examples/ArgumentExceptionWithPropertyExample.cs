using System;

namespace Microsoft.Workshop.Net.ExceptionHandling.Examples
{
    public class ArgumentExceptionWithPropertyExample : ExecutableExample
    {
        public override void Execute()
        {
            this.sum(1, null);
        }

        public int sum(int? a, int? b)
        { 
            if(!a.HasValue) {
                throw new ArgumentNullException("Sum operands must be non null", nameof(a));
            }
            else if(!b.HasValue) {
                throw new ArgumentNullException("Sum operands must be non null", nameof(b));
            }
            return a.Value+b.Value;
        }
    }
}