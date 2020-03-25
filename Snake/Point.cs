 using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
     class Point
    {
        //координаты точки
        public int x;
        public int y;
        public char sym;

        public Point()
        {
           
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }


        public Point(Point p) //чтобы задавать точки с помощью другой точки
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        
        
        public void Move(int offset, Direction direction) //метод движения в зависимсти от выбора направления
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.DOWN)
            {
                y = y - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y + offset;
            }
            
        }

        public void Draw() //нарисовать объект
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear() //очистить объект
        {
            sym = ' ';
            Draw();
        }
        public override string ToString() //метод для наглядности
        {
            return x + ", " + y + ", " + sym;
        }
        
        public bool IsHit(Point p) //проверка на равенство координат
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
