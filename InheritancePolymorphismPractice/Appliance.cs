using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public abstract class Appliance
    {
        //field
        private bool isElectric;

        //property
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //Constructors - NONE

        //Methods
        public abstract void Work();
        
    }
}
