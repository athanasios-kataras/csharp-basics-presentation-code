using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Decorator
{
    public class CompressionBigDataCacheDecorator : BigDataCacheDecorator
    {
        public CompressionBigDataCacheDecorator(IBigDataCache wrappee) : base(wrappee)
        {
        }

        public override T GetObjectByKey<T>(string key)
        {
            var value = wrappee.GetObjectByKey<T>(key);
            return this.Decompress(value);
        }

        public override bool SetObject(string key, object obj)
        {
            return wrappee.SetObject(key, this.Compress(obj));
        }

        private T Decompress<T>(T value)
        {
            throw new NotImplementedException();
        }

        private object Compress(object obj)
        {
            throw new NotImplementedException();
        }
    }
}