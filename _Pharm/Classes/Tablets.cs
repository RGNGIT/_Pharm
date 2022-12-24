using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Таблетки
    [Serializable]
    internal class Tablets: Drug
    {

        private string _form;
        private string _kind;

        public Tablets(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, string form, string kind, int amount)
            : base(timeUntil, name, usageMethod, dose, price, group, amount)
        {
            this._form = form;
            _kind = kind;
        }

        public string form
        {
            get { return _form; }
            set { _form = value; }
        }

        public string kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

    }
}
