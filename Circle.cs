using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpShapes
{
    internal class Circle : Shape
    {
        
        private double radius;

        public Circle(int r) 
        {
            this.radius = r; 
        }

        public override double GetArea()
        {
            return 3.14 * radius * radius; //not the correct math but whatever :D
        }
    }
}

