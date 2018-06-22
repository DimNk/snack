using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine()
        {
            pList = new List<Point>();
            Point p1 = new Point(1,2,'H');
            Point p2 = new Point(7,2,'t');
            Point p3 = new Point(8,2,'8');
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
        }
        public void Draw()
        {
            foreach (var i in pList) {
                Console.SetCursorPosition(i.X1, i.Y1);
                Console.Write(i.Letter1);
            }
        }
    }
}
