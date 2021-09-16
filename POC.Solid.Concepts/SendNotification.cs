using POC.Solid.Concepts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Solid.Concepts
{
    public class SendNotification
    {
        private readonly INotificationSenderService _notificationSenderService;

        public SendNotification(INotificationSenderService notificationSenderService)
        {
            _notificationSenderService = notificationSenderService;
        }

        public enum NotificationType {
            Information,
            Success,
            Error
        };

        public void SendNotificationMessage(NotificationType nType,string title, string message)
        {
            switch (nType)
            {
                case NotificationType.Information:
                    _notificationSenderService.SendInfoNotification(title, message);
                    break;
                case NotificationType.Success:
                    _notificationSenderService.SendSuccessNotification(title, "Insert", message);
                    break;
                case NotificationType.Error:
                    _notificationSenderService.SendErrorNotification(title, 404, message);
                    break;
                default:
                    break;
            }
        }
    }
}
