using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Shape
    {
        //fields
        private int sides;

        //properties
        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        //Consturctors

        public Shape()
        {

        }
        public Shape (int sides)
        {
            this.sides = sides;
        }

        //Methods

        public class Rectangle : Shape
        {
            private double area;

            public Rectangle(double area)
            {
                this.area = area;
            }
            public double Area
            {
                get { return this.area; }
                set { this.area = value; }
            }
        }
    }
}
