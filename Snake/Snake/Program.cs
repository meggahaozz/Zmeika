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
            Console.SetBufferSize(80, 25);

            Figure upLine = new HorizontalLine(0, 78, 0, '+');
            Figure downLine = new HorizontalLine(0, 78, 24, '+');
            Figure leftLine = new VerticalLine(0, 24, 0, '+');
            Figure rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            CPoint p = new CPoint(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            //Console.ReadKey();
        }
    }
}
