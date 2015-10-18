using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;
        Random r = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public CPoint CreateFood()
        {
            int x = r.Next(3, mapWidth - 3);
            int y = r.Next(3, mapHeight - 3);
            return new CPoint(x, y, sym);
        }
    }
}
