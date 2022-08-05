namespace Curso8.Entities
{
    internal class ImportedProduct : Product
    {
        public double customFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            this.customFee = customFee;
        }

        public ImportedProduct()
        {

        }

        public double totalPrice()
        {
            return price + customFee;
        }

        public override string priceTag()
        {
            return name + " $ " + totalPrice().ToString() + " Customs fee: $ " + customFee.ToString();
        }
    }
}
