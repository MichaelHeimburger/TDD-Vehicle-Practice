using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vehicle
    {
        private int speed; //fields
        private string modelname;
        private int tires;
        public int Tires // properties
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
        public string ModelName
        {
            get { return this.modelname; }
            set { this.modelname = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public Vehicle()
        {
            //defualt constructor
        }

        public int MaxSpeed()
        {
            int maxSpeed = Speed * Tires;
                return maxSpeed;
        }
        public virtual int MinSpeed()
        {
            int minSpeed = Speed - Tires;
            return minSpeed;
        }



    } // class
}
