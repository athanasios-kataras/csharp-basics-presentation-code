using System.Collections.Generic;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Formatter;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Validators;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder
{
    public class RestService: IService
    {
        public RestService() {

        }

        public RestService(List<IRequestValidator> reqValidators) {
            
        }

        public RestService(List<IResponseValidator> respValidators) {
            
        }

        public RestService(List<IResponseFormatter> respFormatters) {
            
        }

        public RestService(List<IRequestValidator> reqValidators, List<IResponseValidator> respValidators) {
            
        }

        public RestService(List<IRequestValidator> reqValidators, List<IResponseValidator> respValidators, List<IResponseFormatter> respFormatters) {
            
        }

        // Etc

        public List<IRequestValidator> reqValidators = new List<IRequestValidator>();
        public List<IResponseValidator> respValidators = new List<IResponseValidator>();
        public List<IResponseFormatter> respFormatters = new List<IResponseFormatter>();

        public void Execute(string name, string request, string response)
        {
            throw new System.NotImplementedException();
        }
    }
}