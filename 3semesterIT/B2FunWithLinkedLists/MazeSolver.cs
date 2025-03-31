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

        public bool solveMazeDFS(Coordinate start) {

            LinkedMazeList stack = new LinkedMazeList();
            stack.insertFirst(start);

            while (stack.first != null)
            {
                maze[stack.first.coordinate.x, stack.first.coordinate.y] = "c";
                for (int i = -1; i < 2; i += 2)
                {
                    Coordinate c1 = new Coordinate(stack.first.coordinate.x + i, stack.first.coordinate.y);
                    Coordinate c2 = new Coordinate(stack.first.coordinate.x, stack.first.coordinate.y + i);

                    if (legalMove(c1))
                    {
                        if (maze[c1.x, c1.y] == "e")
                        {
                            return true;
                        }
                        maze[c1.x, c1.y] = "s";
                        stack.insertFirst(c1);
                        stack.first.path = stack.first.path.Concat(new Coordinate[] { c1 }).ToArray();
                    }
                    if (legalMove(c2))
                    {
                        if (maze[c2.x, c2.y] == "e")
                        {
                            return true;
                        }
                        maze[c2.x, c2.y] = "s";
                        stack.insertFirst(c2);
                        stack.first.path = stack.first.path.Concat(new Coordinate[] { c2 }).ToArray();
                    }
                }
                maze[stack.first.coordinate.x, stack.first.coordinate.y] = "S";
                stack.removeFirst();
            }
            return false;
        }

        public int solveMazeBFS(Coordinate start) {
            DoubleLinkedMazeList que = new DoubleLinkedMazeList();
            que.insertLast(start);

            while (que.first != null) { 
                maze[que.first.coordinate.x, que.first.coordinate.y] = "c";
                for (int i = -1; i < 2; i += 2)
                {
                    Coordinate c1 = new Coordinate(que.first.coordinate.x + i, que.first.coordinate.y);
                    Coordinate c2 = new Coordinate(que.first.coordinate.x, que.first.coordinate.y + i);

                    if (legalMove(c1))
                    {
                        if (maze[c1.x, c1.y] == "e")
                        {
                            return que.first.path.Length;
                        }
                        maze[c1.x, c1.y] = "s";
                        que.insertLast(c1);
                        que.last.path = que.first.path.Concat(new Coordinate[] { c1 }).ToArray();
                    }
                    if (legalMove(c2))
                    {
                        if (maze[c2.x, c2.y] == "e")
                        {
                            return que.first.path.Length;
                        }
                        maze[c2.x, c2.y] = "s";
                        que.insertLast(c2);
                        que.last.path = que.first.path.Concat(new Coordinate[] { c2 }).ToArray();
                    }
                }
                maze[que.first.coordinate.x, que.first.coordinate.y] = "S";
                que.removeFirst();
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
            return true;
        }
    }
}
