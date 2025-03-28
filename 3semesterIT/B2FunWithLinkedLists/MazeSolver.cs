using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.A11LinkedList;

namespace ThirdSemesterIT.B2FunWithLinkedLists
{
    public class MazeSolver
    {
        // The maze will have these following valid options,
        // "w" : wall, you cannot walk into a wall
        // "," : passage, a unsearched passage
        // "S" : searched, this position has been searched
        // "s" : this is waiting to be searched
        // "c" : current position
        // "e" : exit
        // "r" : Route to exit
        // s, S and C could be replaced with w simplify the code, but they are useful to
        public string[,] maze { get; set; }

        public MazeSolver(string[,] maze)
        {
            this.maze = maze;
        }

        public int solveMazeBFS(Coordinate start) {
            DoubleLinkedMazeList que = new DoubleLinkedMazeList();
            que.addLast(start);

            while (que.first != null) { 
                maze[que.first.coordinate.x, que.first.coordinate.y] = "c";

                
                

            }

            return -1;
        }

        public bool legalMove(Coordinate coordinate)
        {
            if (coordinate.x < 0 || coordinate.x >= maze.GetLength(0)) {
                return false;
            }
            if (coordinate.y < 0 || coordinate.y >= maze.GetLength(1))
            {
                return false;
            }

            if (maze[coordinate.x, coordinate.y] == ",")
            {
                return true;
            }
            else if (maze[coordinate.x, coordinate.y] == "e")
            {
                return true;
            }
            return false;
        }
    }
}
