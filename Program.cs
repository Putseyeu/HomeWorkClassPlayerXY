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
            char xCoordinate = 'X';
            char yCoordinate = 'Y';
            char playerSign = '$';
            OutputMessage( xCoordinate, playerSign);            
            coordinateX = ReadInt();
            OutputMessage( yCoordinate, playerSign); 
            coordinateY = ReadInt(); 
            Player player = new Player(coordinateX, coordinateY);
            renderer.DrawPlayer(player.CoordinateX, player.CoordinateY);
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

        static void OutputMessage(char coordinate, char playerSign)
        {
            Console.WriteLine($"Введите значение по {coordinate} для координат {playerSign}");
        }
    }

    class Player
    {
        private readonly int _xMinCoordinate = 5;
        private readonly int _xMaxCoordinate = 25;
        private readonly int _yMinCoordinate = 5;
        private readonly int _yMaxCoordinate = 25;
        private readonly string _nameCoordinateX = "X";
        private readonly string _nameCoordinateY = "Y";       
        public int CoordinateX { get; private set; }        
        public int CoordinateY { get; private set; }       

        public Player(int x, int y)
        {
            CoordinateX = AppointValue(x, _xMinCoordinate, _xMaxCoordinate, _nameCoordinateX);
            CoordinateY = AppointValue(y, _yMinCoordinate, _yMaxCoordinate, _nameCoordinateY);
        }

        private int AppointValue( int value, int numberMin, int numberMax, string coordinate)
        {
            int number;
            if (value < numberMin)
            {
                Console.WriteLine($"Значение для {coordinate} установлено по умолчанию на минимальное {numberMin}");
                number = numberMin;
            }
            else if (value > numberMax)
            {
                Console.WriteLine($"Значение для Х установлено по умолчанию на максимальное {numberMax}");
                number = numberMax;
            }
            else
            {
                number = value;
            }
            return number;
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
