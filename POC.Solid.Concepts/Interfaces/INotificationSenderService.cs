using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Solid.Concepts.Interfaces
{
    public interface INotificationSenderService
    {
        public void SendInfoNotification(string title, string message);
        public void SendErrorNotification(string error, int errorNumber, string message);
        public void SendSuccessNotification(string title, string activity, string message);
    }
}
