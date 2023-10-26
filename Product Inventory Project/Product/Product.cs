namespace Product_Inventory_Project.Product
{
    public class Product
    {
        public string title;
        public decimal coast;
        public int id;
        public int quantity;

        public Product() { }

        public Product(string title, decimal coast, int id, int quantity)
        {
            this.title = title;
            this.coast = coast;
            this.id = id;
            this.quantity = quantity;
        }
    }
}
