﻿using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine line2 = new VerticalLine(2, 10, 6, '*');
            line2.Drow();



            Console.ReadLine();
        }
       

       
    }

}
    

