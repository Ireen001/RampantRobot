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

            //Locatie
            Location_Of_Robot locatie1 = new Location_Of_Robot(RowMechanic, ColMechanic);

            if (directions == 'a')
            {
                locatie1.c--;
                // Randen
                if (locatie1.c < 0)
                    locatie1.c = 0;
            }
            else if (directions == 'w')
            {
                locatie1.r--;
                // Randen
                if (locatie1.r < 0)
                    locatie1.r = 0;
            }
            else if (directions == 'd')
            {
                locatie1.c++;
                // Randen
                if (locatie1.c > colLength - 1)
                    locatie1.c = colLength - 1;
            }
            else if (directions == 's')
            {
                locatie1.r++;
                // Randen
                if (locatie1.r > rowLength - 1)
                    locatie1.r = rowLength - 1;
            }
            return locatie1;
        }
    }
}
