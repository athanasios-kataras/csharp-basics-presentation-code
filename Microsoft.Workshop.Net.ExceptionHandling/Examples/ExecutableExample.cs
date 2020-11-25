using System;

namespace Microsoft.Workshop.Net.ExceptionHandling.Examples
{
    public abstract class ExecutableExample
    {
        public abstract void Execute();

        public static implicit operator ExecutableExample(CustomException v)
        {
            throw new NotImplementedException();
        }
    }
}