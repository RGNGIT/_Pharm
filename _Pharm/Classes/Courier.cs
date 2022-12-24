using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    [Serializable]
    internal class Courier
    {

        private string _name;
        private int _deliveryAmount;

        public Courier(string name) 
        {
            this._name = name;
            this._deliveryAmount = 0;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int deliveryAmount 
        {
            get { return _deliveryAmount; }
            set { _deliveryAmount = value; }
        }

    }
}
