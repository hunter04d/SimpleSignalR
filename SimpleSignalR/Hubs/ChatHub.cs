using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SimpleSignalR.Models;

namespace SimpleSignalR.Hubs
{
    public class ChatHub : Hub
    {
        private readonly AppDbContext _appDbContext;

        // DI should work in here
        public ChatHub(AppDbContext appDbContext) => _appDbContext = appDbContext;

        // Cannot use mvc DI bindings: this is not mvc
        public async Task SendMessage(Message message)
        {
            if (message.Content == null || message.Owner == null)
                return;
            await _appDbContext.Messages.AddAsync(message);
            await _appDbContext.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}