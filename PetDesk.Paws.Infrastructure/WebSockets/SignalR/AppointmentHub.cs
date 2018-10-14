using Microsoft.AspNetCore.SignalR;
using PetDesk.Paws.Application.UseCases.SendClientMessages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Infrastructure.WebSockets.SignalR
{
    public class AppointmentHub : Hub, IAppointmentHub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
