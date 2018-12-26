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
        public Location_Of_Robot Move(int rowLength, int colLength, int robots, int RobotRow, int RobotCol)
        {
            int directions;
            Location_Of_Robot Move = new Location_Of_Robot(RobotRow, RobotCol);

            directions = random_directions.Next(0, 3);


            if (directions == 0)
            {
                Move.c--;
                if (Move.c < 0)
                    Move.c = 0;
            }
            else if (directions == 1)
            {
                Move.c++;
                if (Move.c > colLength - 1)
                    Move.c = colLength - 1;
            }
            else if (directions == 2)
            {
                Move.r--;
                if (Move.r < 0)
                    Move.r = 0;
            }
            else if (directions == 3)
            {
                Move.r++;
                if (Move.r > rowLength - 1)
                    Move.r = rowLength - 1;
            }
            return Move;
        }

        public Location_Of_Robot Startpositie(int rowLength, int colLength)
        {
            Location_Of_Robot Startpositie= new Location_Of_Robot(0, 0);
            Startpositie.r = random_directions.Next(0, rowLength);
            Startpositie.c = random_directions.Next(0, colLength);
            return Startpositie;
        }
    }

}
