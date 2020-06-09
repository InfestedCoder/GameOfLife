using System;
namespace GameOfLife
{
    public class Game
    {
<<<<<<< HEAD
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
=======
        public void isAlive()
        {
            int M = 6, N = 6;

            // Intiliazing the grid. 
            int[,] grid = {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

            // Displaying the grid 
            Console.WriteLine("Original Generation");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (grid[i, j] == 0)
                        Console.Write(".");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            nextGeneration(grid, M, N);
        }

        // Function to print next generation 
        static void nextGeneration(int[,] grid,
                                   int M, int N)
        {
            int[,] future = new int[M, N];

            // Loop through every cell 
            for (int l = 1; l < M - 1; l++)
            {
                for (int m = 1; m < N - 1; m++)
                {

                    // finding no Of Neighbours 
                    // that are alive 
                    int aliveNeighbours = 0;
                    for (int i = -1; i <= 1; i++)
                        for (int j = -1; j <= 1; j++)
                            aliveNeighbours +=
                                    grid[l + i, m + j];

                    // The cell needs to be subtracted 
                    // from its neighbours as it was  
                    // counted before 
                    aliveNeighbours -= grid[l, m];

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if ((grid[l, m] == 1) &&
                                (aliveNeighbours < 2))
                        future[l, m] = 0;

                    // Cell dies due to over population 
                    else if ((grid[l, m] == 1) &&
                                 (aliveNeighbours > 3))
                        future[l, m] = 0;

                    // A new cell is born 
                    else if ((grid[l, m] == 0) &&
                                (aliveNeighbours == 3))
                        future[l, m] = 1;

                    // Remains the same 
                    else
                        future[l, m] = grid[l, m];
                }
            }

            Console.WriteLine("Next Generation");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (future[i, j] == 0)
                        Console.Write(".");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
>>>>>>> 5d537d2830ea8c97759d57c4821bd9e43f01adc7
        }
    }
}
