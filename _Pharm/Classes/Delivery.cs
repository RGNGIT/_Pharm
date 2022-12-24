using System;
using System.Collections.Generic;

namespace _Pharm.Classes
{
    [Serializable]
    internal class Delivery : Order
    {

        private Courier _courier;
        private Customer _customer;

        public Delivery(DateTime date, string name, string address, Customer customer, Courier courier, List<Drug> drugs) : base(date, name, address, drugs)
        {
            this._customer = customer;
            _courier = courier;
            _courier = courier;
        }

        private double countPrice()
        {
            double temp = 0;
            foreach(var drug in base.drugs)
            {
                temp += drug.price;
            }
            return temp;
        }

        public Customer customer
        {
            get { return _customer; } set { _customer = value; }
        }

        public double price
        {
            get { return countPrice(); }
        }

        public Courier courier
        {
            get { return this._courier; }
            set { this._courier = value; }
        }

    }
}
