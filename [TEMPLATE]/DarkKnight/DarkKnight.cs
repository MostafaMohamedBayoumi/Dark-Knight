using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public struct Location
    {
        int x, y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }
    public static class DarkKnight
    {
        #region YOUR CODE IS HERE
        //Your Code is Here:
        //==================
        /// <summary>
        /// Given the dimention of the board and the current location of the DarkKnight, calculate the min number of moves to reach the given target or return -1 if can't be reach ed
        /// </summary>
        /// <param name="N">board dimension</param>
        /// <param name="src">current location of the DarkKnight</param>
        /// <param name="target">target location</param>
        /// <returns>min number of moves to reach the target OR -1 if can't reach the target</returns>





         public static int Play(int N, Location src, Location target)
         {
             if (src.Equals(target))
                 return 0;


             if (N == 0)
                 return -1;


             int[,] board = new int[N + 1, N + 1];

             int[,] dxy = { {1, 2}, {1, -2},
                            {-1, 2},{-1, -2} };


             Queue<Location> queue = new Queue<Location>();
             queue.Enqueue(src);
             board[src.X, src.Y] = 1;

             while (queue.Count > 0)
             {
                 Location needed = queue.Dequeue();

                 if (needed.X == target.X && needed.Y == target.Y)

                     return board[needed.X, needed.Y] - 1;


                 for (int i = 0; i < dxy.GetLength(0); i++)
                 {

                     int x = needed.X + dxy[i, 0];
                     int y = needed.Y + dxy[i, 1];

                     if (x > 0 && x <= N && y > 0 && y <= N && board[x, y] == 0)
                     {
                         queue.Enqueue(new Location { X = x, Y = y });
                         board[x, y] = board[needed.X, needed.Y] + 1;
                     }
                 }
             }

             return -1;
         }

       




        #endregion
    }
}
