using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DepartmentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public void AddItem(string itemName)
        {
            Item i = new Item();
            i.Name = itemName;
            Department.Instance.ListOfItems.Add(i);
        }

        public int GetItemCount()
        {
            return Department.Instance.ListOfItems.Count;
        }
    }
}
