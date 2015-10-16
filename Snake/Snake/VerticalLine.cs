using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<CPoint> pList;

        public VerticalLine(int yBottom, int yTop, int x, char sym)
        {
            pList = new List<CPoint>();
            for (int y = yBottom; y <= yTop; y++)
            {
                CPoint p = new CPoint(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (CPoint p in pList)
            {
                p.Draw();
            }
        }
    }
}
