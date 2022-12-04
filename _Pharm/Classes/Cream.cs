using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Мазь
    internal class Cream : Drug
    {

        private bool _isHot;
        private string _zone;

        public Cream(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, bool isHot, string zone)
            : base(timeUntil, name, usageMethod, dose, price, group)
        {
            _isHot = isHot;
            _zone = zone;
        }

        public bool isHot
        {
            get { return _isHot; }
            set { _isHot = value; }
        }

        public string zone
        {
            get { return this._zone; }
            set { this._zone = value; }
        }

    }
}
