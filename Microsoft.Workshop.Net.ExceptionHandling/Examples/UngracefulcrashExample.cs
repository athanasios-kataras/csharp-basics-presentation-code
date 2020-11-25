namespace Microsoft.Workshop.Net.ExceptionHandling.Examples
{
    public class UngracefulcrashExample : ExecutableExample
    {
        public UngracefulcrashExample()
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}

