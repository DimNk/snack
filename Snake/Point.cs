using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int X1 { get; set; }
        int Y1 { get; set; }
        char Point1 { get; set; }
        public Point(int X1, int Y1, char Point1)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.Point1 = Point1;
        }
        public void SetPoint(int X1,int Y1,char Point1)
        {           
            Console.SetCursorPosition(X1, Y1);
            Console.Write(Point1);
        }
        public void SetPoint()
        {
            Console.SetCursorPosition(X1, Y1);
            Console.Write(Point1);
        }
    }
}
