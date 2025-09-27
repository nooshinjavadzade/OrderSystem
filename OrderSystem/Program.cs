using OrderSystem.Log;
using OrderSystem.Models;
using OrderSystem.Notifiers;
using OrderSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            INotifier notifier = new EmailNotifier();

            var orderService = new OrderService(logger, notifier);

            orderService.CreateOrder(new Order { Product = "Laptop" });
        }
    }
}
