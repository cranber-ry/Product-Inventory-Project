namespace Product_Inventory_Project.Product
{
    internal class Inventory
    {
        public decimal sum = 0;

        public void Products(List<Product> products)
        {
            foreach (var unit in products)
            {
                Console.WriteLine($"Наименование продукта: {unit.title}\n" +
                    $"Цена за единицу: {unit.coast}\n" +
                    $"id: {unit.id}\n" +
                    $"Количество: {unit.quantity}\n");
            }
        }

        public void InventorySum(List<Product> products)
        {
            foreach (var product in products)
            {
                sum += product.coast;
            }
            Console.WriteLine($"Сумма всех продуктов в инвентаре составляет {sum}");
        }

        public Inventory() { }
    }
}
