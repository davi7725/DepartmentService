using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DepartmentServer
{
    class UpdateRequest
    {
        Broadcast broadcast;
        int count;
        ServiceReference1.Service1Client service;

        public UpdateRequest(Broadcast b)
        {
            service = new ServiceReference1.Service1Client();
            broadcast = b;
            count = 0;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"Updating info: {count} + {service.GetItemCount()}");
                if (count < service.GetItemCount())
                {
                    broadcast.FireEvent();
                    count = service.GetItemCount();
                }
                Thread.Sleep(6000);
            }
        }
    }
}
