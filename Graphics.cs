using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sokoban
{
    class Graphics
    {
        public void Display(int[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    switch (data[i,j])
                    {
                        default: Console.CursorLeft += 2; break;
                        case 1: Console.Write("W "); break;
                        case 2: Console.Write("B "); break;
                        case 3: Console.Write("G "); break;
                        case 4: Console.Write("P "); break;
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
