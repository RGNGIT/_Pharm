using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Лекарство
    internal class Drug
    {

        private DateTime _timeUntil;
        private string _name;
        private string _usageMethod;
        private double _dose;
        private double _price;
        private string _group;

        public Drug(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group)
        {
            this._timeUntil = timeUntil;
            this._name = name;
            this._usageMethod = usageMethod;
            this._dose = dose;
            this._price = price;
            this._group = group;
        }

        public DateTime timeUntil
        {
            get { return _timeUntil; }
            set { _timeUntil = value; }
        }

        public string name
        {
            get { return _name; }
            set { this._name = value; }
        }

        public string usageMethod
        {
            get { return _usageMethod; }
            set { this._usageMethod = value; }
        }

        public double dose
        {
            get { return _dose; }
            set { this._dose = value; }
        }

        public double price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        public string group
        {
            get { return this._group; }
            set { this._group = value; }
        }

    }
}
