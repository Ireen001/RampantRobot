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

            const int rowLength = 5;
            const int colLength = 12;
            int robots = 7;
            int turns = 50;
            bool robotsMove = true;
            Factory factory = new Factory();
            factory.plotting(rowLength, colLength, robots, turns, robotsMove);
            Console.ReadLine();

        }
    }
}
