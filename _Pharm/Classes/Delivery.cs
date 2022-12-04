using System;

namespace _Pharm.Classes
{
    internal class Delivery : Order
    {

        private Courier _courier;
        private Customer _customer;
        private double _price;

        public Delivery(DateTime date, string name, string address, Customer customer, double price, Courier courier, Drug drug) : base(date, name, address, drug)
        {
            this._customer = customer;
            this._price = price;
            _courier = courier;
            _courier = courier;
        }

        public Customer customer
        {
            get { return _customer; } set { _customer = value; }
        }

        public double price
        {
            get { return _price; } set { _price = value; }
        }

        public Courier courier
        {
            get { return this._courier; }
            set { this._courier = value; }
        }

    }
}
