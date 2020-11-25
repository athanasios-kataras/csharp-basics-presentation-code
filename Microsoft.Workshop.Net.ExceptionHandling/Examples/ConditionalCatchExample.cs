using System;

namespace Microsoft.Workshop.Net.ExceptionHandling.Examples
{
    public class ConditionalCatchExample : ExecutableExample
    {
        public override void Execute()
        {
            try {
                Console.Write("Give a:");
                var a = Console.ReadLine();
                Console.Write("Give b:");
                var b = Console.ReadLine();
                sumPositiveIntegers(a, b);
            }
            catch(ArgumentOutOfRangeException ex) when(ex.ParamName == "a") {
                Console.WriteLine(ex + ":b");
            }
            catch(ArgumentOutOfRangeException ex) when(ex.ParamName == "b") {
                Console.WriteLine(ex.ToString() + ":b");
            }
        }

        private int sumPositiveIntegers(string a, string b)
        {
            int aValue;
            Int32.TryParse(a, out aValue);
            int bValue;
            Int32.TryParse(b, out bValue);
            if(aValue < 0) {
                throw new ArgumentOutOfRangeException("Negative integers are not allowed", nameof(a));
            }
            if (bValue > 1000) {
                throw new ArgumentOutOfRangeException("Integers over 1000 are not allowed. Use sumlong instead", nameof(b));
            }
            return (aValue+bValue);
        }
    }
}