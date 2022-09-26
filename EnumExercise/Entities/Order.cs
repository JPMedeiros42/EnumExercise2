using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EnumExercise.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Clients { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client clients)
        {
            Moment = moment;
            Status = status;
            Clients = clients;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem order in Items)
            {
                sum += order.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Clients);
            sb.AppendLine("Order items:");
            foreach (OrderItem obj in Items)
            {
                sb.AppendLine(obj.ToString());
            }
            sb.AppendLine("Total price: R$"+Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
