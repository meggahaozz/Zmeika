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
    }
}
