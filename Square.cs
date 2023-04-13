using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is the child class - inherits parent class functions
namespace OOpShapes
{
    internal class Square : Shape 
        //defining fields for the child class
    {
        private int side;

        public Square(int a) //set value to field by using constructor
        {
            this.side = a; //side fields will get the value of a, this way doesn't need set, get
        }

        public override double GetArea()
        {
            return this.side * this.side; //square area is a*a
        }
    }
}
