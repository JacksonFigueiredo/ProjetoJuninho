using EnumProject.Entities;
using EnumProject.Entities.Enums;

namespace EnumProject
{
    internal class Program
    {
        //Enum é representado pelo Tipo / Valor

        static void Main(string[] args)
        {
            Order order = new Order { 
                Id = 1, Moment = DateTime.Now, Status = OrderStatus.PendingPayment
            };

            Order order2 = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = Enum.Parse<OrderStatus>("PendingPayment") // ou o numero
            };

            Console.WriteLine("{0}, {1}, {2}",order.Id,order.Moment,order.Status);
            Console.WriteLine("{0}, {1}, {2}", order2.Id, order2.Moment, order2.Status);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

        }
    }
}