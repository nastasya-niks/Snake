﻿using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.SetBufferSize(5, 5);

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
            p.Draw();


            Console.ReadLine();
        }
       

       
    }

}
    

