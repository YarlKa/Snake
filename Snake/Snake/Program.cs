using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HeandleKey(key.Key);
                }
            }

        }
    }
}
