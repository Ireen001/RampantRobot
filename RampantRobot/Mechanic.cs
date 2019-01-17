using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampantRobot
{
    class Mechanic
    {

        public Location_Of_Robot Move(char directions, int RowMechanic, int ColMechanic, int rowLength, int colLength)
        {

            //Locatie van Mechanic
            Location_Of_Robot location1 = new Location_Of_Robot(RowMechanic, ColMechanic);

            if (directions == 'a')
            {
                location1.c--;
                // Randen
                if (location1.c < 0)
                    location1.c = 0;
            }
            else if (directions == 'w')
            {
                location1.r--;
                // Randen
                if (location1.r < 0)
                    location1.r = 0;
            }
            else if (directions == 'd')
            {
                location1.c++;
                // Randen
                if (location1.c > colLength - 1)
                    location1.c = colLength - 1;
            }
            else if (directions == 's')
            {
                location1.r++;
                // Randen
                if (location1.r > rowLength - 1)
                    location1.r = rowLength - 1;
            }
            return location1;
        }
    }
}
