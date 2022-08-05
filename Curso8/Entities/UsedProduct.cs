namespace Curso8.Entities
{
    internal class UsedProduct : Product
    {
       public DateTime manufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name,price) 
        {
            this.manufactureDate = manufactureDate;
        }

        public UsedProduct()
        {

        }

        public override string priceTag()
        {
            return name + " (used) $ " + price.ToString() + " (Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
