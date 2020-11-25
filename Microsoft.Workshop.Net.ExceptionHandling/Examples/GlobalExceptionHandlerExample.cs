using System;

namespace Microsoft.Workshop.Net.ExceptionHandling.Examples
{
    public class GlobalExceptionHandlerExample : ExecutableExample
    {
        public override void Execute()
        {
            AppDomain applicationDomain = AppDomain.CurrentDomain;
            applicationDomain.UnhandledException += new UnhandledExceptionEventHandler(CustomExceptionHandler);

            throw new NullReferenceException();
        }

        private void CustomExceptionHandler(object sender, UnhandledExceptionEventArgs e) {
            Console.WriteLine("Sorry, nothing to do about that");
        }
    }
}