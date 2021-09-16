using Microsoft.Extensions.DependencyInjection;
using POC.Solid.Concepts.Classes;
using POC.Solid.Concepts.Interfaces;
using System;

namespace POC.Solid.Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<INotificationSenderService, EmailSender>()
                .AddScoped<SendNotification>()
                .BuildServiceProvider();

            var sendNotification = serviceProvider.GetService<SendNotification>();

            sendNotification.SendNotificationMessage(SendNotification.NotificationType.Success, "Cliente nuevo", "El cliente fulanito ha sido insertado");            
        }
    }
}
