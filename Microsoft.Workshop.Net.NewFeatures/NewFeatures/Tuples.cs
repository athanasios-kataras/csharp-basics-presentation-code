namespace Microsoft.Workshop.Net.NewFeatures.NewFeatures
{
    using System;
    public class Tuples
    {
        public Tuple<int,int> GetOldTuple() {
            return new Tuple<int,int> (1,2);
        }
        public (int,int) GetNewTuple() {
            return (1,2);
        }
    }
}