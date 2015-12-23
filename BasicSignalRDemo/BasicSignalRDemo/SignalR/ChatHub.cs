using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace BasicSignalRDemo.SignalR
{
    public class ChatHub : Hub
    {
        /*
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }*/
        public void Send(string name, string msg)
        {
            Clients.All.broadcastMessage(name, msg);
        }
    }
}