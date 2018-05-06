using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace CardCombatGameServer.Hubs
{
  public class GameHub : Hub
  {
    public Task Send(string message)
    {
      return Clients.All.SendAsync("Send", message);
    }
  }
}
