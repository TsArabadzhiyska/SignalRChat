using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        /*
        The SendMessage method can be called by any connected client.
            It sends the received message to all clients.SignalR code 
            is asynchronous to provide maximum scalability.
        */
    }
}
