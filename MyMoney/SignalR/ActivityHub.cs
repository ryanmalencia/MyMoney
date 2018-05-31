using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using MyMoney.Interfaces;

namespace MyMoney.SignalR
{
    [HubName("ActivityHub")]
    public class ActivityHub : Hub
    {
        private readonly Activity _activityHub;

        public ActivityHub() : this(Activity.Instance) { }

        public ActivityHub(Activity activity)
        {
            _activityHub = activity;
        }

        public IEnumerable<IAccountEvent> getAll()
        {
            return _activityHub.GetAll();
        }
    }
}