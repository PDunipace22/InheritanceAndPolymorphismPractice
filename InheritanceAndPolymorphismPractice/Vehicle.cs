using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Vehicle
    {
        private int doors;
        private int wheels;
        private string make;
        private string color;

        public int Doors
        {
            get { return this.doors; }
            set { this.doors = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Vehicle()
        {
            //default constructor
        }
    }
}