namespace Microsoft.Workshop.Net.NewFeatures.NewFeatures
{
    using System;
    using System.Linq;
    public class IndicesAndRanges
    {
        string[] words = new string[]
        {
                        // index from start    index from end
            "The",      // 0                   ^9
            "quick",    // 1                   ^8
            "brown",    // 2                   ^7
            "fox",      // 3                   ^6
            "jumped",   // 4                   ^5
            "over",     // 5                   ^4
            "the",      // 6                   ^3
            "lazy",     // 7                   ^2
            "dog"       // 8                   ^1
        };


        public void PrintFromLast(int index)
        {
            Console.WriteLine($"The last word is {words[^index]}");
        }

        internal void PrintRange(int v1, int v2)
        {
            var wordList = words[v1..v2].ToList();
             Console.WriteLine($"The phrase is {wordList.Aggregate("", (c, n) => c + " " + n)}");
        }
        

        internal void PrintReverseRange(int v1, int v2)
        {
            var wordList = words[^v2..^v1].ToList();
             Console.WriteLine($"The phrase is {wordList.Aggregate("", (c, n) => c + " " + n)}");
        }
    }
}