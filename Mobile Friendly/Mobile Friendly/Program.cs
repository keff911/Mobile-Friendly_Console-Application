using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
// MADE BY KEVIN STEVELMANS
// copyright 2017

namespace Mobile_Friendly
{
    class Program
    {
        #region CHOISE FOR MAXIMUM SCREEN
        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;
        #endregion

        #region CHOISE MENU
        private static void ChoiseMenu()
        {
            Console.Clear();
            Console.WriteLine("type 1 for the current window size or type 2 for the maximum size");
            Console.WriteLine();
            Console.Write("Choose the size of the window: ");
            string WindowSizeChoise = Console.ReadLine();
            Console.Clear();

            switch (WindowSizeChoise)
            {
                case "1":

                    break;

                case "2":
                    ShowWindow(ThisConsole, MAXIMIZE);
                    break;

                case "3":
                    ShowWindow(ThisConsole, MAXIMIZE);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("With the code ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\"Console.SetCursorPosition\"");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" you can choose where you want to set your");
                    Console.Write("Written text with ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\"Console.WriteLine\"");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" or ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\"Console.Write\"");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("But the problem is that you need to give your program the coordinates of the location where you want to place your text.");
                    Console.WriteLine("If you found the coordinates of the place you want to put your text it won't be Mobile Friendly, and that is why I created this formula:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Console.SetCursorPosition((Console.WindowWidth - ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("W");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(") / 2, (Console.WindowHeight - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("H");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(") / 2);");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("With this formula you can make a mobile friendly program, because this formula will get your screen width and height and set the text in the middle.");
                    Console.WriteLine("for example, if you start this program up and choose option 1 and 2 you will see that the X's always stay in the middle");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("for this test were the W and the H the following settings:");
                    Console.WriteLine();
                    Console.WriteLine("For the first X on top:               For the middle X's:               And for the last and lowest X:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("W = -0                                W = -2                            W = -0");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("H = -2                                H = -0                            H = +2");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("W  =  THE WIDTH OF YOUR TEXT (WITH SPACE'S)");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("H  =  THE HEIGHT OF YOUR TEXT (THIS IS THE HEIGHT OF THE CONSOLE WINDOW) (how higher the number, how lower the text)");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The W and the H have to be numbers!!");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Now, you are probably asking: Kevin, why is the Height of the first X -2 and the second -0?");
                    Console.WriteLine("Why are you taking steps of two?");
                    Console.WriteLine("Well, if I would know why Visual Studio counts a ConsoleLine for two I would like to tell you, but for now this is a");
                    Console.WriteLine("mystery for me to. But when you need to go down one line, or up you need to count that for two in this formula.");
                    Console.WriteLine();
                    Console.WriteLine("I hope this formula will help you with your coding and I hope you will understand what this peace of code does");
                    Console.Write("If you have any questions, please ask me by mail on: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Kevin.CodeQuestions@gmail.com");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine();
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("And please remember, I am still a student too. Good luck!");

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to go back to the choise menu...");
                    Console.ReadLine();
                    ChoiseMenu();
                    break;

                default:
                    MessageBox.Show("Error: That is an invailed charcater, please try again", "Error");
                    ChoiseMenu();
                    break;
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Console.Title = "Mobile Friendly command | Visual Studio Console Application";
            ChoiseMenu();
            Console.Clear();

            /*
            With the Console.SetCursorPosition you can choose where you want to place your text written with the Console.WriteLine command
            I made this formula for a mobile friendly program, Start the program and choose 3 int the menu for more explanation.
            */
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth - 0) / 2, (Console.WindowHeight - 2) / 2);
            Console.WriteLine(" X ");
            Console.SetCursorPosition((Console.WindowWidth - 2) / 2, (Console.WindowHeight - 0) / 2);
            Console.WriteLine("X X X");
            Console.SetCursorPosition((Console.WindowWidth - 0) / 2, (Console.WindowHeight + 2) / 2);
            Console.WriteLine(" X ");
            Console.ReadLine();
        }
    }
}
