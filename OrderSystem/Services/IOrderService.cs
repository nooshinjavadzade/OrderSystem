using OrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Services
{
    internal interface IOrderService
    {
        void CreateOrder(Order order);
    }
}
