﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<CPoint> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<CPoint>();
            for (int x = xLeft; x <= xRight; x++)
            {
                CPoint p = new CPoint(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach( CPoint  p in pList)
            {
                p.Draw();
            }
        }
    }
}
