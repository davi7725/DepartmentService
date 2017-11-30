using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DepartmentServer
{
    class Server
    {
        Broadcast b;
        public Server()
        {
            b = new Broadcast();
            Thread updateRequest = new Thread(new UpdateRequest(b).Run);
            updateRequest.Start();

            TcpListener connection = new TcpListener(IPAddress.Any, 12000);
            connection.Start();

            while (true)
            {
                Socket s = connection.AcceptSocket();
                Console.WriteLine("New connection!");
                Thread t = new Thread(() => new ClientHandler().Run(s,b));
                t.Start();
            }
        }
    }
}
