using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Validators;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder
{
    public class ServicesDirector
    {
        private IServiceBuilder builder;

        public ServicesDirector(IServiceBuilder builder) {
            this.builder = builder;
        }

        public void ConstructSessionService() {
            this.builder.Reset();
            this.builder.AddRequestValidator(new SessionValidator());
        }

        public void ConstructPublicService() {
            this.builder.Reset();
        }

        public IService GetService() {
            return builder.GetService();
        }
    }
}