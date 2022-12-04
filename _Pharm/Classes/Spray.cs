using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Спрей
    internal class Spray: Drug
    {

        private string _zone;
        private string _kind;

        public Spray(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, string zone)
            : base(timeUntil, name, usageMethod, dose, price, group)
        {
            _zone = zone;
        }

        public string zone
        {
            get { return _zone; }
            set { this._zone = value; }
        }

        public string kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

    }
}
