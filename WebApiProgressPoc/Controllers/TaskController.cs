using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiProgressPoc.Services;

namespace WebApiProgressPoc.Controllers
{
    public class TaskController : ApiController
    {
        [HttpGet]
        public void LongTask(string id)
        {
            Task.Run(() =>
                {
                    var p = new ProgressHub();
                    p.NotifyProgress(id, 0);


                    Thread.Sleep(2000);
                    p.NotifyProgress(id, 20);


                    Thread.Sleep(1000);
                    p.NotifyProgress(id, 30);


                    Thread.Sleep(2000);
                    p.NotifyProgress(id, 50);


                    Thread.Sleep(3000);
                    p.NotifyProgress(id, 80);


                    Thread.Sleep(1000);
                    p.NotifyProgress(id, 90);

                    Thread.Sleep(1000);
                    p.NotifyProgress(id, 100);
                }
            );
        }
    }
}
