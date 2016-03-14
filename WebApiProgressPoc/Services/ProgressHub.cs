using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApiProgressPoc.Services
{
    public class ProgressHub : Hub
    {
        
        public void NotifyProgress(string taskId, int percentage)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
            hubContext.Clients.All.updateProgressBar(taskId, percentage);
        }
        
    }
}