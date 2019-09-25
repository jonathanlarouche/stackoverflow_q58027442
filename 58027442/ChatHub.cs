using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _58027442
{
    public class ChatHub : Hub
    {
        static int Temperature = new Random().Next();

        [HubMethodName("change_weather")]
        public void ChangeWeather(int temperature)
        {
            Temperature = temperature;
            Clients.Others.NotifyUser(temperature);

        }

        [HubMethodName("get_weather")]
        public void GetWeather()
        {
            Clients.Caller.NotifyUser(Temperature);
        }
    }
}