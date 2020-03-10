using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';
            Draw(1, 3, '*');
            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';
            Draw(4, 5, '#');
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
    }

