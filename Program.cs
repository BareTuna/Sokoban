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

            int[,] test = new int[,]
            {
                { 1, 1, 1, 1 },
                { 1, 4, 0, 1 },
                { 1, 0, 0, 1 },
                { 1, 1, 1, 1 }
            };
            Graphics graphics = new Graphics();
            graphics.Display(test);

            Console.ReadKey(true);
        }
    }
}
