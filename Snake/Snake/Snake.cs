using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(CPoint tail, int length, Direction direction)
        {
            for (int i = 0; i < length; i++)
            {
                CPoint p = new CPoint(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
