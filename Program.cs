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
            int coordinateX;
            int coordinateY;            
            Console.WriteLine("Введите значение по X для координат $");            
            coordinateX = ReadInt();
            Console.WriteLine("Введите значение по Y для координаты $");
            coordinateY = ReadInt(); 
            Player player = new Player(coordinateX, coordinateY);
            renderer.DrawPlayer(player.X, player.Y);
        }

        static int  ReadInt()
        {
            bool completed = false;
            int intValue = 0;
            while (completed == false)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out  intValue))
                {                    
                    completed = true;
                   
                }
                else
                {
                    Console.WriteLine("Не верный ввод значения.Введите  целое число.");
                }
            }
            return intValue;           
        }
    }

    class Player
    {
        private int _xMin = 5;
        private int _xMax = 25;
        private int _yMin = 5;
        private int _yMax = 25;
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
                SetValue(ref _x, value, _xMin, _xMax);                
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
                SetValue(ref _y, value, _yMin, _yMax);
            }
        }

        static void SetValue(ref int _number, int value, int _numberMin, int _numberMax)
        {
            if (value < _numberMin)
            {
                Console.WriteLine($"Значение для Х установлено по умолчанию на минимальное {_numberMin}");
                _number = _numberMin;
            }

            else if (value > _numberMax)
            {
                Console.WriteLine($"Значение для Х установлено по умолчанию на максимальное {_numberMax}");
                _number = _numberMax;
            }

            else
            {
                _number = value;
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
