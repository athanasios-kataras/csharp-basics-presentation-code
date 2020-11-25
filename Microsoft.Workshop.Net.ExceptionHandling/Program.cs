using System;
using Microsoft.Workshop.Net.ExceptionHandling.Examples;

namespace Microsoft.Workshop.Net.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose examle \n 1. Ungraceful exception \n 2. ArgumentNull exception \n 3. Conditional Example \n 4. Global handler example \n 5. Custom Exception");
            var output = Console.ReadLine();
            ExecutableExample executableExample;
            switch (output)
            {
                case "1":
                    executableExample = new UngracefulcrashExample();
                    break;
                case "2":
                    executableExample = new ArgumentExceptionWithPropertyExample();
                    break;
                case "3":
                    executableExample = new ConditionalCatchExample();
                    break;
                case "4":
                    executableExample = new GlobalExceptionHandlerExample();
                    break;
                case "5":
                    executableExample = new CustomExceptionExample();
                    break;
                default:
                    throw new NotImplementedException("This path is not implemented");
            }
            executableExample.Execute();
        }
    }
}
