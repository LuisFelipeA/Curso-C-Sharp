using EnumeracaoComposicao.Entities;
using EnumeracaoComposicao.Entities.Enums;

namespace EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1200,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}