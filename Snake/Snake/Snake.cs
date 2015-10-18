using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(CPoint tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<CPoint>();
            for (int i = 0; i < length; i++)
            { 
                CPoint p = new CPoint(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            CPoint tail = pList.First();
            pList.Remove(tail);
            CPoint head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public CPoint GetNextPoint()
        {
            CPoint head = pList.Last();
            CPoint nextPoint = new CPoint(head); ;
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
