using System;
using System.Runtime.Serialization;

namespace Microsoft.Workshop.Net.ExceptionHandling.Examples
{
    public class CustomException: Exception {
        public static readonly string DefaultMessage = "CustomException raised";

        public int SomeImpactfullInt {get; set;}

        public CustomException(): base(DefaultMessage) {

        }

        public CustomException(string message): base(message) {

        }

        public CustomException(string message, Exception innerException): base(message, innerException) {

        }
        
    }
    public class CustomExceptionExample : ExecutableExample
    {
        public override void Execute()
        {
            try
            {
                this.throwsCustomException();
            }
            catch(CustomException cex) when(cex.SomeImpactfullInt == 1)
            {
                Console.WriteLine("We caugth it");  
                Console.WriteLine(cex);    
            }
        }

        private void throwsCustomException() {
            throw new CustomException("Yiiiihaaaa") {
                SomeImpactfullInt = 1
            };
        }
    }
}