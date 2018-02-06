using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class DeathEater
    {
        //fields 
        private bool hasDarkMark;

        //Properties
        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructor
        public DeathEater() : base(false)
        {

        }
    }
}
