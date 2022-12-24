using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _Pharm.Classes
{
    [Serializable]
    sealed class PharmContainer
    {
        public List<Drug> drugs;
        public List<Customer> customers;
        public List<Courier> couriers;
        public List<Order> orders;
    }

    // Склад
    internal class Storage
    {
        private List<Drug> drugs;
        private List<Customer> customers;
        private List<Courier> couriers;
        private List<Order> orders;

        public void SerializeData()
        {
            PharmContainer tempContainer = new PharmContainer();
            tempContainer.drugs = this.drugs;
            tempContainer.customers = this.customers;
            tempContainer.couriers = this.couriers;
            tempContainer.orders = this.orders;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("PharmDB.auf", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tempContainer);
            stream.Close();
        }

        public void DeserializeData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("PharmDB.auf", FileMode.Open, FileAccess.Read, FileShare.Read);
            PharmContainer tempContainer = (PharmContainer)formatter.Deserialize(stream);
            stream.Close();
            this.drugs = tempContainer.drugs;
            this.customers = tempContainer.customers;
            this.couriers = tempContainer.couriers;
            this.orders = tempContainer.orders;
        }

        public void ShitSort()
        {
            drugs.Sort((x, y) => string.Compare(x.name, y.name));
        }

        public List<Drug> Drugs { 
            get { return drugs; } 
            set { this.drugs = value; }
        }

        public List<Customer> Customers
        {
            get { return customers; }
            set { this.customers = value; }
        }

        public List<Courier> Couriers
        {
            get { return couriers; }
            set { this.couriers = value; }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set { this.orders = value; }
        }

        public Storage()
        {
            this.drugs = new List<Drug>();
            this.customers = new List<Customer>();
            this.couriers = new List<Courier>();
            this.orders = new List<Order>();
        }

    }
}
