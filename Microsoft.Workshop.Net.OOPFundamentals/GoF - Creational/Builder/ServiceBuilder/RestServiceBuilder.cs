using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Formatter;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Validators;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder
{
    public class RestServiceBuilder : IServiceBuilder
    {
        private RestService sessionService;

        public RestServiceBuilder() {
            sessionService = new RestService();
        }

        public bool AddRequestValidator(IRequestValidator validator)
        {
            sessionService.reqValidators.Add(validator);
            return true;
        }

        public bool AddResponseFormatter(IResponseFormatter formatter)
        {
            sessionService.respFormatters.Add(formatter);
            return true;
        }

        public bool AddResponseValidator(IResponseValidator validator)
        {
            sessionService.respValidators.Add(validator);
            return true;
        }

        public IService GetService()
        {
            return sessionService;
        }

        public void Reset()
        {
            sessionService = new RestService();
        }
    }
}