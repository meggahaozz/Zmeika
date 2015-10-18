using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class CPoint
    {
        int x;
        int y;
        char sym;

        public CPoint(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public CPoint(CPoint p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch(direction)
            {
                case Direction.RIGHT:
                    {
                        x += offset;
                        break;
                    }
                case Direction.LEFT:
                    {
                        x -= offset;
                        break;
                    }
                case Direction.UP:
                    {
                        y -= offset;
                        break;
                    }
                case Direction.DOWN:
                    {
                        y += offset;
                        break;
                    }
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
