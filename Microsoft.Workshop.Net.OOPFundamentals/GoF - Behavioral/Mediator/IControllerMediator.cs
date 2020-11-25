namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Mediator
{
    public interface IControllerMediator
    {
         void Notify(object sender, string ev);
    }
}