using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampantRobot
{
    class Locations
    {
        public int r { get; set; }
        public int c { get; set; }

        public Locations(int r, int c)
        {
            this.r = r;
            this.c = c;
        }
    }
}
