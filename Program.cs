﻿using System;
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
