using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSMB_Worldmap_Editor
{
    public class frame
    {
        int xPos, yPos, zPos, direction;

        public frame(int x, int y, int z, int d)
        {
            xPos = x;
            yPos = y;
            zPos = z;
            direction = d;
        }

        public int x
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public int z
        {
            get { return zPos; }
            set { zPos = value; }
        }

        public int d
        {
            get { return direction; }
            set { direction = value; }
        }
    }
}
