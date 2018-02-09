﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Dishwasher : Appliance
    {
        //fields
        //invisible

        //Properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }

        //Constructors
        public Dishwasher()
        {
            //default constructor
        }

        public Dishwasher(double decibelLevel, bool hasHeatDry)
        {
            DecibelLevel = decibelLevel;
            HasHeatDry = hasHeatDry;
        }

        //Methods
        public override void Work()
        {
            Console.WriteLine("I was your dishes.");
            Console.WriteLine("Wash wash wash");
        }
    }
}
