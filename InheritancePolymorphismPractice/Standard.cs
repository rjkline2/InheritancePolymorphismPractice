using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Standard : Membership
    {
        //fields
        //invisible

        //Properties
        public int Cost { get; set; }

        //Constructors
        public Standard()
        {
            //default constructor
        }
        public Standard(int cost) //overloaded constructor
        {
            Cost = cost; //instead of using the this.thingy = thing value thing....
        }

        //Methods
        public override void Activate()
        {
            base.Activate();
        }
    }
}
