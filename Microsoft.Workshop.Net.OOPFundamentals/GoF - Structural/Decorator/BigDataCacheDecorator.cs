namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Decorator
{
    public abstract class BigDataCacheDecorator : IBigDataCache
    {
        protected IBigDataCache wrappee;

        protected BigDataCacheDecorator(IBigDataCache wrappee)
        {
            this.wrappee = wrappee;
        }

        public virtual T GetObjectByKey<T>(string key)
        {
            return wrappee.GetObjectByKey<T>(key);
        }

        public virtual bool SetObject(string key, object obj)
        {
            return wrappee.SetObject(key, obj);
        }
    }
}