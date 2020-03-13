using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 3, '*');
            p.Draw();

            Point p2 = new Point(4, 5, '#');       
            p2.Draw();
          
            Console.ReadLine();
        }
        
    }
    }

