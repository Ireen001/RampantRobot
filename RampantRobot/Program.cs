using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampantRobot
{
    class Program
    {

        static void Main(string[] args)
        {
            //Lengte van de rijen
            const int rowLength = 5;
            //Lengte van de kolommen
            const int colLength = 12;
            //Aantal robots in het spel
            int robots = 7;
            //Aantal turns
            int turns = 10;
            //True: Robots bewegen , False: Robots staan stil
            bool robotsMove = true;
            Factory factory = new Factory();
            factory.plotting(rowLength, colLength, robots, turns, robotsMove);
            Console.ReadLine();

        }
    }
}
