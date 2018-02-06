using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    public class Rectangle : Shape
    {
        
            private double area;
        // A derived class does NOT inherit the constructors of the base class. 
        // However, the constructors of the base class can be accessed using the "base" keyword. 
        
            public Rectangle(double area) : base(4)
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
