using exercício_enum_lists.Entities.Enum;
using System.Text;
using System.Globalization;

namespace exercício_enum_lists.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; private set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {

        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in OrderItem)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY:");

            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);

            //Client
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items:");

            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtototal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            sb.Append($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}