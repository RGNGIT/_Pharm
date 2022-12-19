using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _Pharm.Classes
{
    internal class Income: Order
    {

        private int _amount;
        private string _nameOfDrug;

        public Income(DateTime date, string name, string address, int amount, string nameOfDrug) : base(date, name, address, null)
        {
            _amount = amount;
            _nameOfDrug = nameOfDrug;
        }

        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public string nameOfDrug
        {
            get { return _nameOfDrug; }
            set { _nameOfDrug = value; }
        }

    }
}
