using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftline.Drow();
            rightLine.Drow();


            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();

            while (true)
            {
                if (Console.KeyAvailable) //проверка на нажатие определенных клавиш
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);                   
                }
                Thread.Sleep(100); //задержка на 100 мл/сек
                snake.Move();
            }



            Console.ReadLine();
        }
       

       
    }

}
    

