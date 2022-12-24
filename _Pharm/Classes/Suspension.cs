using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Суспензия
    [Serializable]
    internal class Suspension: Drug
    {

        private string _kind;

        public Suspension(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, string kind, int amount)
            : base(timeUntil, name, usageMethod, dose, price, group, amount)
        {
            this._kind = kind;
        }

        public string kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

    }
}
