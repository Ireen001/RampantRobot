using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampantRobot
{
    class Robot
    {
        public Random random_directions = new Random();
        public Locations Move(int rowLength, int colLength, int RobotRow, int RobotCol)
        {
            int directions;
            Locations Move = new Locations(RobotRow, RobotCol);

            // Genereer random directions
            directions = random_directions.Next(0, 3);

            if (directions == 0)
            {
                Move.c--;
                // Randen
                if (Move.c < 0)
                    Move.c = 0;
            }
            else if (directions == 1)
            {
                Move.c++;
                // Randen
                if (Move.c > colLength - 1)
                    Move.c = colLength - 1;
            }
            else if (directions == 2)
            {
                Move.r--;
                // Randen
                if (Move.r < 0)
                    Move.r = 0;
            }
            else if (directions == 3)
            {
                Move.r++;
                // Randen
                if (Move.r > rowLength - 1)
                    Move.r = rowLength - 1;
            }
            return Move;
        }


        public Locations Startposition(int rowLength, int colLength)
        {
            Locations Startposition = new Locations(0, 0);
            Startposition.r = random_directions.Next(0, rowLength);
            Startposition.c = random_directions.Next(0, colLength);
            return Startposition;
        }
    }

}
