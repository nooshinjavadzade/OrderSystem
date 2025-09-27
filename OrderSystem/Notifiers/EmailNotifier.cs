using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Notifiers
{
    internal class EmailNotifier : INotifier
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }
    }
}
