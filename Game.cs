using System;
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
        public static bool Running = true;
        private static Action State = Menu;

        // Menu Selection
        private static int _menuSelection;
        private static int MenuSelection
        {
            get
            {
                return _menuSelection;
            }
            set
            {
                // (e.g.) If at top of selection, and press up, it moves to the bottom of the selection
                _menuSelection = Wrap(value, MenuOptions.Count);
            }
        }

        private static Dictionary<string, Action> MenuOptions;



        private static void Init()
        {
            // Create Menu Options
            MenuOptions = new Dictionary<string, Action>
            {
                { "Test Mode", () => { State = TestMode; } },

                { "Quit", () => { State = Menu; Running = false; } }
            };
        }

        public static void Run()
        {
            Init();

            while (Running)
            {
                State.Invoke();
            }
        }

        private static void Menu()
        {

            Console.Clear();

            // Write each option
            foreach (KeyValuePair<string,Action> key in MenuOptions)
            {
                Console.WriteLine($"  {key.Key}");
            }

            // Display which option is selected with an arrow, >
            Console.CursorTop = MenuSelection;
            Console.Write(">");
            Console.CursorTop = MenuOptions.Count + 1;
            Console.WriteLine("(You can also type 'Q' to quit.)");

            // Update input
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:

                    MenuSelection -= 1;
                    break;

                case ConsoleKey.DownArrow:

                    MenuSelection += 1;
                    break;

                case ConsoleKey.Enter:

                    // Invoke the function selected in MenuOptions.
                    MenuOptions.ElementAt(MenuSelection).Value.Invoke();
                    break;

                #region // Shortcuts //

                // Quit
                case ConsoleKey.Q:
                    goto case ConsoleKey.Escape;

                case ConsoleKey.Escape:
                    MenuOptions["Quit"].Invoke();
                    break;

                // Test mode
                case ConsoleKey.T:
                    MenuOptions["Test Mode"].Invoke();
                    break;

                // Endless Mode (When implemented)
                case ConsoleKey.E:
                    // Menu Options["Endless Mode"].Invoke();
                    break;

                // Story Mode (When implemented)
                case ConsoleKey.S:
                    // Menu Options["Story Mode"].Invoke();
                    break;
                    
                #endregion // Shortcuts to quit or play //
            }

        }

        private static int Wrap(int value, int around)
        {
            return (value % around + around) % around;
        }

        private static void TestMode()
        {
            
            Graphics graphics = new Graphics();
            
            // may change this line to set the cursor position to get rid of flickering
            Console.Clear();

            graphics.Display(CurrentGameboard);

            // input line
            Console.Write("\n>>> ");
            var inp = Console.ReadKey(true);
                
            switch (inp.Key)
            {
                default: break;
                case ConsoleKey.UpArrow: Console.WriteLine("↑"); break;
                case ConsoleKey.DownArrow: Console.WriteLine("↓"); break;
                case ConsoleKey.LeftArrow: Console.WriteLine("←"); break;
                case ConsoleKey.RightArrow: Console.WriteLine("→"); break;
                case ConsoleKey.Q: State = Menu; break;
                case ConsoleKey.Escape: State = Menu; Running = false; return; 
            }
            
        }

    }
}
