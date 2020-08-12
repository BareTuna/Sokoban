using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    

    class Gameboard
    {
        public GameElement[,] Data;

        
        public Gameboard (GameElement[,] board)
        {
            Data = board;
        }

        /// <summary>
        /// Creates a randomized Gameboard object
        /// </summary>
        /// <param name="width">The width of the Gameboard.</param>
        /// <param name="height">The height of the Gameboard.</param>
        /// <param name="boxes">How many boxes (and goals) will be in the Gameboard.</param>
        public Gameboard (int width, int height, int boxes)
        {
            throw new NotImplementedException("Does not guarantee the parameters and player to be correctly placed.");
            /*
            if (width < 3 || height < 3)
                throw new Exception("Game board width or height is too small to be playable!");

            Data = new GameElement[height, width];
            
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    Data[i, j] = GameElement.Air;
                }
            }

            // Create border of walls
            // Walls running east-west
            for (int i = 0; i < Data.GetLength(1); i++)
            {
                Data[0, i] = GameElement.Wall;
                Data[Data.GetLength(0), i] = GameElement.Wall;
            }
            // Walls running north-south
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                Data[0, i] = GameElement.Wall;
                Data[Data.GetLength(0), i] = GameElement.Wall;
            }

            // Randomize Boxes and Goals
            Random rnd = new Random();
            for (int i = 0; i < boxes; i++)
            {
                // Randomize Boxes
                int x = rnd.Next(1, Data.GetLength(1) - 1);
                int y = rnd.Next(1, Data.GetLength(0) - 1);
                Data[y, x] = GameElement.Box;

                // Randomize Goal
                x = rnd.Next(1, Data.GetLength(1) - 1);
                y = rnd.Next(1, Data.GetLength(0) - 1);
                Data[y, x] = GameElement.Goal;
            }

            // Randomize Player Location

            Data[ rnd.Next(1, Data.GetLength(1) - 1), rnd.Next(1, Data.GetLength(0) - 1) ] = GameElement.Player;


            /**/
        }
    }
}
