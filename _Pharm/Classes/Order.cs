using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    internal class Order
    {

        private Drug _drug;
        private DateTime _date;
        private string _name;
        private string _address;

        public Order(DateTime date, string name, string address, Drug drug)
        {
            _date = date;
            _name = name;
            _address = address;
            _drug = drug;
        }

        public Drug drug
        {
            get { return _drug; }
            set { _drug = value; }
        }

        public DateTime date
        {
            get { return _date; }
            set { _date = value; } 
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

    }
}
