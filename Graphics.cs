using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sokoban
{
    class Graphics
    {
        public void Display(GameElement[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    switch (data[i,j])
                    {
                        default: Console.CursorLeft += 2; break;
                        case GameElement.Wall:      Console.Write("██"); break;
                        case GameElement.Box:       Console.Write("[]"); break;
                        case GameElement.Goal:      Console.Write("▒▒"); break;
                        case GameElement.Player:    Console.Write("☺ "); break;
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
