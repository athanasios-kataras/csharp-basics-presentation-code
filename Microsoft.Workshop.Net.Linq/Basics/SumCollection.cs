using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.Linq.Basics
{
    public class SumCollection :IEnumerable<int>
    {
        IEnumerator<int> enumerator;

        public SumCollection(int[] collection) {
            this.enumerator = new SumCollectionEnumerator(collection);
        }
        public IEnumerator<int> GetEnumerator()
        {
            return this.enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.enumerator;
        }
    }

    public class SumCollectionEnumerator : IEnumerator<int>
    {
        private int[] collection;
        private int index = -1;

        public SumCollectionEnumerator(int[] collection)
        {
            this.collection = collection;
        }

        public int Current {
            get {
                int sum = collection[0];
                for(int  i = 1; i <= index; i++) {
                    sum += collection[i];
                }
                return sum;
            }
        } 

        object IEnumerator.Current => (object)this.Current;

        public void Dispose() {}

        public bool MoveNext()
        {
            index++;
            bool hasnext = index < collection.Length;
            #region Hidden
            // if (!hasnext){
            //     this.Reset();
            // }
            #endregion
            return hasnext;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}