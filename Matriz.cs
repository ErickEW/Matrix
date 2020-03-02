using System;

namespace Matrix
{
    class Matrix
    {
        private int[,] grid;

        private int gridSize;    

        public Matrix(int [,] gridValues, int gridSize) {
            this.grid = gridValues;
            this.gridSize = gridSize;
        }
        public int CalculateDeterminantMexicanStyle() {
            return this.grid[0, 0] * this.grid[1, 1] * this.grid[2, 2]
            + this.grid[0, 1] * this.grid[1, 2] * this.grid[2, 0]
            + this.grid[0, 2] * this.grid[1, 0] * this.grid[2, 1]
            - this.grid[0, 2] * this.grid[1, 1] * this.grid[2, 0]
            - this.grid[0, 0] * this.grid[1, 2] * this.grid[2, 1]
            - this.grid[0, 1] * this.grid[1, 0] * this.grid[2, 2];
        }

        public void PrintMatrix () {
            for(int y = 0; y < this.gridSize; y++) {
                for (int x = 0; x < this.gridSize; x++) {
                    Console.Write(this.grid[y,x]);

                }
                Console.WriteLine();
            }
        }
    }
}
