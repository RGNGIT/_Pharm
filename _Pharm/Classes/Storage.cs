using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Pharm.Classes
{
    // Склад
    internal class Storage
    {
        private List<Drug> drugs;

        public List<Drug> Drugs { 
            get { return drugs; } 
            set { this.drugs = value; }
        }

        public Storage()
        {
            this.drugs = new List<Drug>();
        }

    }
}
