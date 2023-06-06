using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProgramming
{
    internal class RectangleCoordinate
    {
        public bool inside(double x, double y, double x1, double y1, double x2, double y2)
        {
            if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
