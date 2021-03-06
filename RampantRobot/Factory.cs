﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RampantRobot
{
    class Factory
    {
        public Mechanic mechanic { set; get; }
        public void plotting(int rowLength, int colLength, int robots, int turns, bool robotsMove)
        {
        again:
            // Lege lijsten en lege matrix
            string[,] grid;
            grid = new string[rowLength, colLength];
            List<int> listrobotrow = new List<int>();
            List<int> listrobotcol = new List<int>();
            List<int> sumgrids = new List<int>();

            //Vul de matrix met'.' characters
            for (int r = 0; r < rowLength; r++)
            {
                for (int c = 0; c < colLength; c++)
                {
                    grid[r, c] = ".";
                }
            }

            // Startpositie mechanic
            grid[0, 0] = "M";
            Robot robot = new Robot();

            // Startpositie Robot
            for (int j = 0; j < robots; j++)
            {
                Locations Startpositie = robot.Startposition(rowLength, colLength);
                int RobotRow = Startpositie.r;
                int RobotCol = Startpositie.c;

                grid[RobotRow, RobotCol] = "R";
                listrobotrow.Add(RobotRow);
                listrobotcol.Add(RobotCol);
                // Zorg dat de robot niet linksboven wordt geplaatst.
                if (RobotRow == 0 && RobotCol == 0)
                {
                    goto again;
                }
            }

            // Check of robots op dezelfde plek gaan staan.
            // Kijk hoeveel dezelfde waardes in de lijst staan. Zo weet je of robots
            // op dezelfde plek staan 
            sumgrids.Clear();
            for (int j = 0; j < robots; j++)
            {
                sumgrids.Add(listrobotrow[j] * 10000 + listrobotcol[j]);
            }
            List<int> distinct = sumgrids.Distinct().ToList();
            if (distinct.Count < robots)
            {
                goto again;
            }

            // Plot de begin matrix
            for (int r = 0; r < rowLength; r++)
            {
                for (int c = 0; c < colLength; c++)
                {
                    Console.Write(string.Format("{0} ", grid[r, c]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.WriteLine("Hartelijk welkom bij het spel Rampant Robots");
            Console.WriteLine("Gebruik de toetsen 'asdw' om een beweging te maken:");

            // Begin van het spel
            int RowMechanic = 0;
            int ColMechanic = 0;
            int statement = 0;
            while (statement <= turns)
            {
                string directions;
                directions = Console.ReadLine();
                Mechanic mechanic = new Mechanic();
                for (int i = 0; i < directions.Length; i++)
                {
                    grid[RowMechanic, ColMechanic] = "."; // Verwijder mechanic
                    Locations Location1 = mechanic.Move(directions[i], RowMechanic, ColMechanic, rowLength, colLength);
                    RowMechanic = Location1.r;
                    ColMechanic = Location1.c;
                    grid[RowMechanic, ColMechanic] = "M"; // Plaats mechanic
                    for (int j = robots - 1; j >= 0; j--)
                    {
                        // Bewaar de posities van de robots
                        int RobotRow = listrobotrow[j];
                        int RobotCol = listrobotcol[j];

                        Locations Move = robot.Move(rowLength, colLength, RobotRow, RobotCol);
                        if (grid[Move.r, Move.c] != "R")// Verplaats de robots als de plek vrij is
                        {
                            if (robotsMove == true) // zorg dat robots bewegen als robotsMove = true
                            {
                                grid[listrobotrow[j], listrobotcol[j]] = "."; // Verwijder robots van vorige turn
                                RobotRow = Move.r;
                                RobotCol = Move.c;
                                listrobotrow[j] = RobotRow;
                                listrobotcol[j] = RobotCol;
                                grid[RobotRow, RobotCol] = "R"; // plaats robots met nieuwe plek
                            }
                        }

                        else // Robots blijven op dezelfde plek staan als de plek bezet is
                        {
                            grid[listrobotrow[j], listrobotcol[j]] = "R";
                        }

                        // Delete robot als mechanic robot tegenkomt
                        if (RobotRow == RowMechanic && RobotCol == ColMechanic)
                        {
                            grid[RowMechanic, ColMechanic] = "M";
                            listrobotrow.RemoveAt(j);
                            listrobotcol.RemoveAt(j);
                            robots--;
                            if (robots <= 0)
                            {
                                Debug.WriteLine("Yes, alle robots zijn geraakt!", robots);
                                statement = turns;
                            }
                            else
                            {
                                Debug.WriteLine("Yes, een robot geraakt! Nog {0} te gaan..", robots);
                            }
                        }
                        grid[RowMechanic, ColMechanic] = "M";
                    }
                }

                // Plot de matrix na het spelen van de ronde
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write(string.Format("{0} ", grid[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
                Console.WriteLine("U heeft nog {0} turns.", turns--);
            }
            statement++;
        }
    }
}

