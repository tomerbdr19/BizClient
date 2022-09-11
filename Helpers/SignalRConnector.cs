using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace BizClient.Helpers
{
    public class SignalRConnector
    {
        private readonly string Path = "http://10.0.2.2:7071/api/";
        private HubConnection Connection;

        public async Task Connect()
        {
            var id = Store.IsUser ? Store.UserId : Store.BusinessId;

            Connection = new HubConnectionBuilder()
            .WithUrl(Path)
            .Build();

            try
            {
                Connection.On<Message>("newMessage", (message) => OnNewMessage(message));
                Connection.On("redeemCoupon", () => OnRedeem());
                await Connection.StartAsync();
                await Store.ServicesStore.SignalRService.StoreId(id, Connection.ConnectionId);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }

        }

        private void OnNewMessage(Message message)
        {
            MessagingCenter.Send<SignalRConnector, Message>(this, "newMessage", message);
        }

        private void OnRedeem()
        {
            MessagingCenter.Send<SignalRConnector>(this, "redeem");

        }
    }
}

