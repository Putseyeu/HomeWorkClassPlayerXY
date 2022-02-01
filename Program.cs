using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassPlayerXY
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            int x;
            int y; 
            int numberInput = 0;
            Console.WriteLine("Введите значение по X для координат $");
            ChekUserInput(ref numberInput);
            x = numberInput;
            Console.WriteLine("Введите значение по Y для координаты $");
            ChekUserInput(ref numberInput);
            y = numberInput;
            Player player = new Player(x, y);
            renderer.DrawPlayer(player.X,player.Y);
        }

        static void ChekUserInput(ref int numberInput)
        {
            bool completed = false;
            while (completed == false)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int intValue))
                {                    
                    numberInput = intValue;
                    completed = true;
                }
                else
                {
                    Console.WriteLine("Не верный ввод значения.Введите  целое число.");
                }
            }
        }
    }

    class Player
    {
        int xMin = 5;
        int xMax = 25;
        int yMin = 5;
        int yMax = 25;
        private int _x;
        private int _y;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < xMin)
                {
                    Console.WriteLine($"Значение для Х установлено по умолчанию на минимальное {xMin}");
                    _x = xMin;
                }

                 else if (value > xMax)
                {
                    Console.WriteLine($"Значение для Х установлено по умолчанию на максимальное {xMax}");
                    _x = xMax;
                }

                else 
                {
                    _x = value;
                }
            }
        }


        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value < yMin)
                {
                    Console.WriteLine($"Значение для Y установлено по умолчанию на минимальное {yMin}");
                    _y = yMin;
                }

                else if (value > yMax)
                {
                    Console.WriteLine($"Значение для Y установлено по умолчанию на максимальное {yMax}");
                    _y = yMax;
                }
                else
                {
                    _y = value;
                }
            }
        }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Renderer
    {
        public void DrawPlayer(int x, int y, char player = '$')
        {
            Console.WriteLine("Значения установлены нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(player);
        }
    }
}
