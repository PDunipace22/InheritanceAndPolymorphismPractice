using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Car : Vehicle
    {
        private int wheels;
        private int people;

        public int Wheels
        {
            get { return this.wheels; }
            set { this.wheels = value; }
        }
        public int People 
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public Car()
        {
            
        }
        public Car(int doors, string color)
        {
            this.Doors = doors;
            this.Color = color;
        }

        public string PeopleCapacity()
        {
            if (people < Doors)
            {
                return "Still space available.";
            }
            else
            {
                return "The car is full.";
            }
        }
    }
}
