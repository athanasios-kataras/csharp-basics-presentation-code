using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.CSharpFeatures.OperatorExtentions
{
    public abstract class CachedArray<T,M>
    {
        // Declare an array to store the data elements.
        private Dictionary<T,M> arr = new Dictionary<T, M>();

        // Define the indexer to allow client code to use [] notation.
        public M this[T i]
        {
            get {
                arr[i] = arr.ContainsKey(i) ? arr[i] : GetValue(i);
                return arr[i];
            }
        }

        public abstract M GetValue(T i);
    }

    public class Book {
        public string ISBN {get; set;}
        public string Author {get; set;}
    }

    /// <summary>
    /// Access books by ISBN 
    /// </summary>
    public class BookCollection : CachedArray<string, Book>
    {
        public override Book GetValue(string i)
        {
            Console.WriteLine("Accessed from api");
            return new Book() { ISBN = "SN2131232", Author = "Me"};
        }
    }
}