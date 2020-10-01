using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatASP.Models
{
    public class MainHub: Hub
    {
        public async Task Broadcast(string userName, string text)
        {
            await Clients.All.SendAsync("GetMessage", userName, text);
        }
    }
}
