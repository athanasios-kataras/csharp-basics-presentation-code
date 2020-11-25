namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Decorator
{
    public class BigDataCache : IBigDataCache
    {
        public T GetObjectByKey<T>(string key)
        {
            var obj = new object();
            // Get something from memory cache
            return (T)obj;
        }

        public bool SetObject(string key, object obj)
        {
            // Somehow add to the cache
            return true;
        }
    }
}