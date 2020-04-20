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

         
            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine Leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 78, '+');
            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();

            Point p1 = new Point(14, 20, '*');
            p1.Draw();
        }
    }
}
