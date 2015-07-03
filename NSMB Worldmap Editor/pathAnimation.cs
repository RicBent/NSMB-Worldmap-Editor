using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSMB_Worldmap_Editor
{
    public class pathAnimation
    {
        int frames, offset;
        int pointerToX, pointerToY, pointerToZ, pointerToDirection;

        public pathAnimation(int of, int fr, int pX, int pY, int pZ, int pD)
        {
            offset = of;
            frames = fr;
            pointerToX = pX;
            pointerToY = pY;
            pointerToZ = pZ;
            pointerToDirection = pD;
        }

        public int of
        {
            get { return offset; }
            set { offset = value; }
        }

        public int fr
        {
            get { return frames; }
            set { frames = value; }
        }

        public int pX
        {
            get { return pointerToX; }
            set { pointerToX = value; }
        }

        public int pY
        {
            get { return pointerToY; }
            set { pointerToY = value; }
        }

        public int pZ
        {
            get { return pointerToZ; }
            set { pointerToZ = value; }
        }

        public int pD
        {
            get { return pointerToDirection; }
            set { pointerToDirection = value; }
        }
    }
}
