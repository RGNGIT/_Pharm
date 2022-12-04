using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    internal class Courier
    {

        private int _deliveryAmount;

        public Courier(int deliveryAmount) 
        {
            this._deliveryAmount = deliveryAmount;
        }

        public int deliveryAmount 
        {
            get { return _deliveryAmount; }
            set { _deliveryAmount = value; }
        }

    }
}
