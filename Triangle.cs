using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpShapes
{
    internal class Triangle : Shape
    {

            private int side;
            private int height;

        public Triangle(int b, int h)
            {
                this.side = b;
                this.height = h;
            }

            public override double GetArea()
            {
                return this.height * this.side / 2;
            }

    }
}

