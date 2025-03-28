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
        public LinkedMazeList linkedList { get; set; } = new();
        public DoubleLinkedMazeList doubleList { get; set; } = new();

        public MazeSolver(string[,] maze)
        {
            this.maze = maze;
        }
    }
}
