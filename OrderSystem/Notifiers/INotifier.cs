using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Notifiers
{
    internal interface INotifier
    {
        void SendMessage(string message);
    }
}
