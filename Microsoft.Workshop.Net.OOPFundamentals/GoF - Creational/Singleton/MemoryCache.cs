using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Singleton
{
    /// <summary>
    /// Thread Safe Singleton Cache Class
    /// </summary>
    public sealed class Cache
    {
        private Cache cache;

        private Cache() {
            
        }

        public Cache GetInstance() {
            if (cache == null) {
                cache = new Cache();
            }
            return cache;
        }
        Dictionary<string, object> _cache = new Dictionary<string, object>();

        public object GetOrCreate(string key, object createItem)
        {
            if (!_cache.ContainsKey(key))
            {
                _cache[key] = createItem;
            }
            return _cache[key];
        }
    }
}