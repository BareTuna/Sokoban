﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public enum GameElement : int
    {
        Air = 0,
        Wall = 1,
        Box = 2,
        Goal = 3,
        Player = 4
    }

    class Game
    {
        public static Gameboard CurrentGameboard;

        public static void Play()
        {
            Graphics graphics = new Graphics();
            
        }

    }
}