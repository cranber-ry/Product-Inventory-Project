using Product_Inventory_Project.Product;

Inventory inventory = new Inventory();

List<Product> products = new List<Product>
{
    new Product("Штаны спортивные", 44, 1, 4),
    new Product("Футболка", 20, 2, 7),
    new Product("Рубашка", 75, 3, 10),
    new Product("Полотенце", 32, 4, 35)
};

inventory.Products(products);
inventory.InventorySum(products);