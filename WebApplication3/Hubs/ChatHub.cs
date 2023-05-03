
using Microsoft.AspNetCore.SignalR;

namespace WebApplication3.Hubs
{
    public class ChatHub : Hub
    {

        public Task SendMessage1(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMsg", user, message);
        }
    }
}
