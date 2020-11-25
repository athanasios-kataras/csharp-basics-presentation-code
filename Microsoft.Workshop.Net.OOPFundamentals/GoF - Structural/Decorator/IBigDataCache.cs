namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Decorator
{
    public interface IBigDataCache
    {
         T GetObjectByKey<T>(string key);
         bool SetObject(string key, object obj);
    }
}