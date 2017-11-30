using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagerz
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            while(true)
            {
                Console.WriteLine("Enter command: ");
                string rsp = Console.ReadLine();

                switch(rsp)
                {
                    case "add":
                        Console.WriteLine("Enter the name of the Item:");
                        string itemName = Console.ReadLine();
                        service.AddItem(itemName);
                        break;
                    case "count":
                        Console.WriteLine(service.GetItemCount().ToString());
                        break;
                    default:
                        Console.WriteLine("no command found");
                        break;
                }
            }
        }
    }
}
