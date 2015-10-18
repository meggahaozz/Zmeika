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
            Console.SetBufferSize(80, 25);
            //отрисовка рамки
            Figure upLine = new HorizontalLine(0, 78, 0, '+');
            Figure downLine = new HorizontalLine(0, 78, 24, '+');
            Figure leftLine = new VerticalLine(0, 24, 0, '+');
            Figure rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //отрисовка змейки
            CPoint p = new CPoint(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //food
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            CPoint food = foodCreator.CreateFood();
            food.Draw();

            //цикл игры
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
                    snake.HandleKey(key.Key);
                }
            }
            //Console.ReadKey();
        }
    }
}
