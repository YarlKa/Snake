﻿using System;
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
            Point p1 = new Point( 1, 3, '*');
            p1.Draw();

            Point p2 = new Point( 4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(2);
            numList.Add(5);
            numList.Add(22);

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> numPoint = new List<Point>();
            numPoint.Add(p1);
            numPoint.Add(p2);

            Console.ReadLine();
         }
    }
}
