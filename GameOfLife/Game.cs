using System;
namespace GameOfLife
{
    public class Game
    {
        /* 
         
         Any live cell with fewer than two live neighbours dies, as if by underpopulation.
         Any live cell with two or three live neighbours lives on to the next generation.
         Any live cell with more than three live neighbours dies, as if by overpopulation.
         Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
         
         */

        public bool isAlive(bool liveCell, int numberOfNeighbors)
        {
            if(liveCell == true && numberOfNeighbors == 2 || numberOfNeighbors == 3)
            {
                return true;
            }

            if (liveCell == false && numberOfNeighbors == 2 || numberOfNeighbors == 1)
            {
                return false;
            }

            return false;
        }
    }
}
