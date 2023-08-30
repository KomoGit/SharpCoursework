namespace StoreManagementProject
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }

        public Product(string name,float price,int qty)
        {
            Name = name;
            Price = price;
            Qty = qty;
        }

        public string RetrieveAllData()
        {
            return $"{Name} {Price} {Qty}";
        }
    }
}
