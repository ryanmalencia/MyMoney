using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using MyMoney.Interfaces;

namespace MyMoney.SignalR
{
    public class Activity
    {
        private readonly static Lazy<Activity> _instance = new Lazy<Activity>(() => new Activity(GlobalHost.ConnectionManager.GetHubContext<ActivityHub>().Clients));
        private readonly ConcurrentDictionary<string, IAccountEvent> _information = new ConcurrentDictionary<string, IAccountEvent>();
        private readonly object _informationLock = new object();
        private readonly TimeSpan _updateInterval = TimeSpan.FromMilliseconds(1000);
        private volatile bool _updatingInformation = false;

        private Activity(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;

        }

        public static Activity Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private IHubConnectionContext<dynamic> Clients
        {
            get;
            set;
        }

        public IEnumerable<IAccountEvent> GetAll()
        {
            return _information.Values;
        }
    }
}