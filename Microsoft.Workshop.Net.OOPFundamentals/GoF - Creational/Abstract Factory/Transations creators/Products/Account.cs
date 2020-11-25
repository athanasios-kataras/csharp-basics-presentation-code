namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Creational.Abstract_Factory.Transations_creators.Products
{
    public class Account : Product
    {
        public override string Code { get; set; }
        public override decimal Balance { get; set; }

        public Account(string code) {
            this.Code = code;
        }
    }
}