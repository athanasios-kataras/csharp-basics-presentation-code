using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Chain_Of_Resp
{
    public class AuthorizationService
    {
        private IAuthorizationHandler firstHandler;
        private IAuthorizationHandler lastHandler;

        public AuthorizationService() {
            firstHandler = new CommonAuthorizationHandler();
            lastHandler = firstHandler;
        }

        public void AddHandler(IAuthorizationHandler handler) {
            lastHandler.SetNext(handler);
            lastHandler = handler;
        }

        public void AuthorizeRequest(params string[] authcontextparams) {
            AuthorizationContext authContext = new AuthorizationContext() {
                // Initialize from authcontext params
            };

            firstHandler.Authorize(authContext);
        }
    }
}