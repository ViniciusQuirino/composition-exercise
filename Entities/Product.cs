namespace exercício_enum_lists.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}