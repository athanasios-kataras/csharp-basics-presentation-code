namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Mediator
{
    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    public class BaseComponent
    {
        protected IControllerMediator _mediator;

        public BaseComponent(IControllerMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IControllerMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}