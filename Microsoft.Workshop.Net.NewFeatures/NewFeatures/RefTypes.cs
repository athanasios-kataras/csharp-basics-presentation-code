namespace Microsoft.Workshop.Net.NewFeatures.NewFeatures
{
    using System;
    public class RefTypes
    {
        public void ExecuteInlineOut()
        {
            string input = "1";
            if (int.TryParse(input, out int result))
                Console.WriteLine(result);
            else
                Console.WriteLine("Could not parse input");
        }
    }
}