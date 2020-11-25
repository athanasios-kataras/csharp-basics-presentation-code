namespace Microsoft.Workshop.Net.Linq.Basics
{
    using System.Collections;
    using System.Collections.Generic;

    public class EnumerableExample : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    public class EnumerableCollection<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}