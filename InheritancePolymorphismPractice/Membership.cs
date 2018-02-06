﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Membership
    {
        //fields
        private int memberID;
        private bool isActive;

        //properties
        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }
        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }
        

        //constructors
        public Membership()
        {
            //default constructor
        }
        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID;
            this.isActive = isActive;
        }

        //methods
        public virtual void Activate()
        {
            if (isActive == false)
            {
                isActive = true;
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }
        }

    }

}
