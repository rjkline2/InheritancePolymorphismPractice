using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class VIP : Membership
    {
        //fields
        //invisibility cloak

        //Properties
        public bool IsSwanky { get; set; }

        //Constructors
        public VIP()
        {
            //defualt constructor
        }
        public VIP(bool isSwanky)
        {
            this.IsSwanky = isSwanky;
        }

        //Methods
        public override void Activate()
        {
            IsSwanky = true;

            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("Your VIP membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your VIP membership is already active.");
            }
        }
    }
}
