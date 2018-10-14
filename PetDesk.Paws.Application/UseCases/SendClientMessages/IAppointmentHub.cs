using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.SendClientMessages
{
    public interface IAppointmentHub
    {
        Task SendMessage(string user, string message);
    }
}
