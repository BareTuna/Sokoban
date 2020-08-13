#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            // please git this message.
            // *get
            // whoops my bad. hopefully this written apology will make up for my horrid, nasty typo.
            // lol doesn't

            Console.Title = "Sokoban";

#if (DEBUG)

            // Gameboard
            int[,] t = new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 4, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 2, 0, 3, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };
            // Convert int[,] to GameElement[,]
            GameElement[,] test = new GameElement[t.GetLength(0), t.GetLength(1)];
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    test[i, j] = (GameElement)t[i, j];
                }
            }

            Graphics graphics = new Graphics();
            graphics.Display(test);

#endif

            Game.Play();

            Console.ReadKey(true);
        }
    }
}
