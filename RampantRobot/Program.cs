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

            string[,] grid;
            const int row = 5;
            const int col = 5;
            string n;
            grid = new string[row, col];



            //fill the grid with '.' characters
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    grid[r, c] = ".";

                }
            }

            grid[0, 0] = "M";
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(string.Format("{0} ", grid[r, c]));

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.WriteLine("Enter the steps:");
            n = Console.ReadLine();
            //Console.Write(string.Format("{0}", n.Length));
            if (n == "s")
            {
            }

            Console.ReadLine();
        }
    }
}
