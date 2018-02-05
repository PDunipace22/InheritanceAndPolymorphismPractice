using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Boat : Vehicle
    {
        private string motor;

        public string Motor
        {
            get { return this.motor; }
            set { this.motor = value; }
        }

        public Boat()
        {

        }
        public Boat(string motor, string color)
        {
            this.motor = motor;
            this.Color = color;
        }

        public string Speed()
        {
            if(motor == Color)
            {
                return "The boat will go faster.";
            }
            else
            {
                return "The boat will go slower.";
            }
        }
    }
}
