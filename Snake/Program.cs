using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Point point = new Point(5, 16, '&');
            //point.Draw();
            //point.Draw(6,12,'7');

            //Point point2 = new Point(7,4,'v');
            //point2.Draw();
            HorizontalLine hl = new HorizontalLine();
            hl.Draw();

            Console.ReadKey();
        }
    }
}
