using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Склад
    internal class Storage
    {
        private List<Drug> drugs;
        private List<Customer> customers;
        private List<Courier> couriers;
        private List<Order> orders;

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
