using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Boat : Vehicle
    {
        public Boat()
        {

         
        }
        public override int MinSpeed()
        {
            int minspeed = Tires + Speed;
            return minspeed;         
        }


    }
}
