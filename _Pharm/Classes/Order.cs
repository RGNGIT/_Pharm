using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    [Serializable]
    internal class Order
    {

        private List<Drug> _drugs;
        private DateTime _date;
        private string _name;
        private string _address;

        public Order(DateTime date, string name, string address, List<Drug> drug)
        {
            _date = date;
            _name = name;
            _address = address;
            _drugs = drug;
        }

        public double orderSum()
        {
            double temp = 0;
            foreach(var drug in this._drugs)
            {
                temp += drug.price;
            }
            return temp;
        }

        public List<Drug> drugs
        {
            get { return _drugs; }
            set { _drugs = value; }
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
