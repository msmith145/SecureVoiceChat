using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
        public void SendAudio(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastAudio(name, message);
        }
        public void SendAuth(string name, string message, string nonce)
        {
            Clients.All.broadcastAuthentication(name, message, nonce);
        }

        public void SendAuthenticationEncryptNonce(string name, string message, string nonce)
        {

            Clients.All.broadcastAuthenticationEncryptNonce(name, message, nonce);
        }

        public void SendAuthenticationConfirmation(string name, string message)
        {

            Clients.All.broadcastAuthenticationConfirmation(name, message);
        }
        public void SendAuthenticationFailure(string name, string message)
        {

            Clients.All.broadcastAuthenticationFailure(name, message);
        }

      
    }
}