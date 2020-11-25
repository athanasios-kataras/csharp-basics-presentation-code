using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Formatter;
using Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder.Validators;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Builder.ServiceBuilder
{
    public interface IServiceBuilder
    {
        void Reset();
        bool AddRequestValidator(IRequestValidator validator);
        bool AddResponseValidator(IResponseValidator validator);
        bool AddResponseFormatter(IResponseFormatter formatter);

        IService GetService();
    }
}