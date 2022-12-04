using System;
using System.Collections.Generic;

namespace _Pharm.Classes
{
    internal class PerperturalCustomer: Customer
    {

        private string _discountNumber;
        private List<Drug> _drugs;

        public PerperturalCustomer(string fIO, DateTime dOB, string phone, string email, string discountNumber, List<Drug> drugs) : base(fIO, dOB, phone, email)
        {
            _discountNumber = discountNumber;
            _drugs = drugs;
        }

        public string discountNumber
        {
            get { return _discountNumber; }
            set { _discountNumber = value; }
        }

        public List<Drug> drugs
        {
            get { return _drugs; }
            set { _drugs = value; }
        }

    }
}
