using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WebSMonitor.Models;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebSMonitor.Models
{
    [HubName("immediateResultTicker")]
    public class ImmediateResultTickerHub : Hub
    {
        private readonly ImmediateResultTicker _immediateResultTicker;

        public ImmediateResultTickerHub() : this(ImmediateResultTicker.Instance) { }

        public ImmediateResultTickerHub(ImmediateResultTicker immediateResulticker)
        {
            _immediateResultTicker = immediateResulticker;
        }

        public IEnumerable<ImmediateResult> GetAllResults()
        {
            return _immediateResultTicker.GetAllResults();
        }

        public void Hello()
        {
            Clients.All.hello();
        }
    }
}