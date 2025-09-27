using OrderSystem.Log;
using OrderSystem.Models;
using OrderSystem.Notifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Services
{
    internal class OrderService : IOrderService
    {
        private readonly ILogger _logger;
        private readonly INotifier _notifier;

        public OrderService(ILogger logger, INotifier notifier)
        {
            _logger = logger;
            _notifier = notifier;
        }
        public void CreateOrder(Order order)
        {
            Console.WriteLine($"Order created for {order.Product}");
            _logger.Log($"Order created: {order.Product}");
            _notifier.SendMessage($"Your order for {order.Product} has been placed.");
        }
    }
}
