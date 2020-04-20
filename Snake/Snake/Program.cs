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
            Point p1 = new Point( 14, 20, '*');
            p1.Draw();

            Console.SetBufferSize( 80, 25 );

            HorizontalLine Upline = new HorizontalLine(0, 80, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 80, 25, '+');
            VerticalLine Leftline = new VerticalLine(0, 0, 25, '+');
            VerticalLine Reightline = new VerticalLine(80, 0, 25, '+');
            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Reightline.Drow();
            
            Console.ReadLine();
         }
    }
}
