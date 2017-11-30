using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentServer
{
    class Broadcast : EventArgs
    {
        public delegate void UpdateClient();
        public event UpdateClient updateClient;

        public void Subscribe(ClientHandler ch)
        {
            updateClient += ch.InformClientOfUpdate;
        }

        public void Unsubscribe(ClientHandler ch)
        {
            updateClient -= ch.InformClientOfUpdate;
        }

        public void FireEvent()
        {
            updateClient.Invoke();
        }
    }
}
