using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        public List<CPoint> pList;

        public void Draw()
        {
            foreach (CPoint p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsHit(CPoint point)
        {
            foreach (var p in pList)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
