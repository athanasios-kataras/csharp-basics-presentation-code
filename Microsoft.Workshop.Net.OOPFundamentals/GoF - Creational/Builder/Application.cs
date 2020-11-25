using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder
{
    public class Application
    {
        HashSet<string> sessionServices;
        public void Serve(string name, string request, string response) {
            IServiceBuilder builder = new RestServiceBuilder();

            ServicesDirector director = new ServicesDirector(builder);
            if(sessionServices.Contains(name)) {
                director.ConstructSessionService();
            } else {
                director.ConstructPublicService();
            }

            var service = builder.GetService();
            service.Execute(name, request, response);
        }
    }
}