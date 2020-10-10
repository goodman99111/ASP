using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatASP.Models
{
    public class MainHub: Hub
    {
        private UserContext db;
        public MainHub(UserContext context)
        {
            db = context;
        }
        public async Task Broadcast(string userName, string text)
        {
            await Clients.All.SendAsync("GetMessage", userName, text);

            var msg = new Message() { Msg = text, User = userName };
            db.Messages.Add(msg);
            await db.SaveChangesAsync();
        }
    }
}
