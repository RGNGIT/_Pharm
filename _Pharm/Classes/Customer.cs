using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    [Serializable]
    internal class Customer
    {

        private string _FIO;
        private DateTime _DOB;
        private string _phone;
        private string _email;

        public Customer(string fIO, DateTime dOB, string phone, string email)
        {
            _FIO = fIO;
            _DOB = dOB;
            _phone = phone;
            _email = email;
        }

        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public DateTime DOB
        {
            get { return this._DOB; }
            set { _DOB = value; }
        }

        public string phone
        {
            get { return _phone; }
            set { this._phone = value; }
        }

        public string email
        {
            get { return _email; }
            set { this._email = value; }
        }

    }
}
