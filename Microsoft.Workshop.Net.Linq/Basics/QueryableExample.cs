using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Microsoft.Workshop.Net.Linq.Basics
{
    public class QueryableExample : IQueryable
    {
        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class QueryableCollectionExample<T> : IQueryable<T>
    {
        Type IQueryable.ElementType => throw new NotImplementedException();

        Expression IQueryable.Expression => throw new NotImplementedException();

        IQueryProvider IQueryable.Provider => throw new NotImplementedException();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}