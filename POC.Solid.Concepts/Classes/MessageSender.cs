using POC.Solid.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Solid.Concepts.Classes
{
    public class MessageSender : INotificationSenderService
    {
        public void SendErrorNotification(string error, int errorNumber, string message)
        {
            throw new NotImplementedException();
        }

        public void SendInfoNotification(string title, string message)
        {
            throw new NotImplementedException();
        }

        public void SendSuccessNotification(string title, string activity, string message)
        {
            throw new NotImplementedException();
        }
    }
}
