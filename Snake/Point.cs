using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public char Letter1 { get; set; }
        public Point() { }
        public Point(int X1, int Y1, char Point1)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.Letter1 = Point1;
        }
        public void Draw(int X1,int Y1,char Point1)
        {           
            Console.SetCursorPosition(X1, Y1);
            Console.Write(Point1);
        }
        public void Draw()
        {
            Console.SetCursorPosition(X1, Y1);
            Console.Write(Letter1);
        }
    }
}
