using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 1;
            p.x = 3;
            p.sym = '*';
            p.Draw();

            Point p2 = new Point();
            p2.x = 1;
            p2.y = 3;
            p2.sym = '#';
            p2.Draw();
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';
            //Draw(1, 3, '*');
            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';
            //Draw(4, 5, '#');
            Console.ReadLine();
        }
        //static void Draw(int x, int y, char sym)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sym);
        //}
    }
    }

