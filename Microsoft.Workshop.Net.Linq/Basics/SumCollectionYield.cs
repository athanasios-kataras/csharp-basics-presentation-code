using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.Linq.Basics
{
    public class SumCollectionYield : IEnumerable<int>
    {
        int[] collection;

        public SumCollectionYield(int[] collection)
        {
            this.collection = collection;
        }
        public IEnumerator<int> GetEnumerator()
        {
            var sum = 0;
            foreach (int item in collection)
            {
                sum += item;
                yield return sum;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}