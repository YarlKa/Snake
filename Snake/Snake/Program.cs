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
            int x1 = 7;
            int y1 = 5;
            char sum1 = '*';

            Draw(x1, y1, sum1);

            int x2 = 4;
            int y2 = 5;
            Char sum2 = '$';

            Draw(x2, y2, sum2);


            Console.ReadLine();
        }
        static void Draw(int x, int y, Char sum)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }
    }
}
