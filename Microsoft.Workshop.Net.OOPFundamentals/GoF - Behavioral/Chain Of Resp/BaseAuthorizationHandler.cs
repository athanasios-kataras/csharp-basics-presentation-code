namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Chain_Of_Resp
{
    public abstract class BaseAuthorizationHandler : IAuthorizationHandler
    {
        private IAuthorizationHandler nextHandler;
        public virtual void Authorize(AuthorizationContext context)
        {
            // Do some oauth stuff
            if(nextHandler != null) {
                nextHandler.Authorize(context);
            }
        }

        public void SetNext(IAuthorizationHandler handler)
        {
            nextHandler = handler;
        }
    }
}