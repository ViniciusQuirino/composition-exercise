namespace exercício_enum_lists.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }
        public Product Product { get; set; }

        public OrderItem(int quant, double pric, Product product)
        {
            Quantity = quant;
            Price = pric;
            Product = product;
        }

        public double SubTotal()
        {
            double sum = 0;
            sum += Quantity * Price;
            return sum;
        }
    }
}