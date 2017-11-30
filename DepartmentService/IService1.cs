using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DepartmentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int GetItemCount();

        [OperationContract]
        void AddItem(string itemName);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "DepartmentService.ContractType".

    [DataContract]
    public class Item
    {
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Department
    {
        private static Department instance = null;
        public static Department Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Department();
                    instance.ListOfItems = new List<Item>();
                }
                return instance;
            }
        }

        [DataMember]
        public List<Item> ListOfItems { get; set; }
    }
}
