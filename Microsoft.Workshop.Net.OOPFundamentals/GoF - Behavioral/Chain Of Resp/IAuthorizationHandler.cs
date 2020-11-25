namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Chain_Of_Resp
{
    public interface IAuthorizationHandler
    {
        void Authorize(AuthorizationContext context);
        void SetNext(IAuthorizationHandler handler);
    }
}