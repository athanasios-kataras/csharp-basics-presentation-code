namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Adapter
{
    public class BondServiceAdapter : IProductService
    {
        private BondService bondService;
        public bool RegisterProduct(InvestmentProduct product)
        {
            var bondProduct = new BondProduct() {
                Code = product.Name,
                Returns = product.RateDetails["Returns"]
            };

            bool success = false;
            this.bondService.Register(bondProduct, ref success);
            return success;
        }
    }
}