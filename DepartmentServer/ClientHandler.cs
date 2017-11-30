using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentServer
{
    class ClientHandler
    {
        NetworkStream ns;
        StreamWriter sw;
        StreamReader sr;

        internal void Run(Socket s, Broadcast b)
        {
            ns = new NetworkStream(s);
            sw = new StreamWriter(ns);
            sr = new StreamReader(ns);
            sw.AutoFlush = true;

            b.Subscribe(this);

            sw.WriteLine("Welcome to the server!");

            bool running = true;

            while (running)
            {
                string msg = sr.ReadLine();

                if (msg == "quit")
                    running = false;
            }

            b.Unsubscribe(this);
            sw.Dispose();
            sr.Dispose();
            ns.Dispose();
            s.Close();
            s = null;

        }

        internal void InformClientOfUpdate()
        {
            Console.WriteLine("Informing Clients");
            sw.WriteLine("New items available");
        }
    }
}
