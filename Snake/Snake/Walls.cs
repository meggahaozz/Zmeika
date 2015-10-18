using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            Figure upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            Figure downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            Figure leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            Figure rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
            wallList.Add(leftLine);
            wallList.Add(rightLine);
            wallList.Add(upLine);
            wallList.Add(downLine);
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
