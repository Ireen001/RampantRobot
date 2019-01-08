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

            const int rowLength = 4;
            const int colLength = 4;
            int robots = 5;
            int turns = 50;
            Factory factory = new Factory();
            factory.plotting(rowLength, colLength, robots, turns);
            Console.ReadLine();
                              
        }
    }
}
