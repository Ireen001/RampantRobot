using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampantRobot
{
    class Location_Of_Robot
    {
        public int r { get; set; }
        public int c { get; set; }

        public Location_Of_Robot(int r, int c)
        {
            this.r = r;
            this.c = c;
        }
    }
}
