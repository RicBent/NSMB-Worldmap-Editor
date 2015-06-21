using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSMB_Worldmap_Editor
{
    public class pathAnimation
    {
        int frames, flag, offset;
        int pointerToX, pointerToY, pointerToZ, pointerToDirection;
        int initialY, initialZ, initialX, initialDirection;

        public pathAnimation(int of, int fr, int fl, int iX, int iY, int iZ, int iD, int pX, int pY, int pZ, int pD)
        {
            offset = of;
            frames = fr;
            flag = fl;
            initialX = iX;
            initialY = iY;
            initialZ = iZ;
            initialDirection = iD;
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

        public int fl
        {
            get { return flag; }
            set { flag = value; }
        }

        public int iX
        {
            get { return initialX; }
            set { initialX = value; }
        }

        public int iY
        {
            get { return initialY; }
            set { initialY = value; }
        }

        public int iZ
        {
            get { return initialZ; }
            set { initialZ = value; }
        }

        public int iD
        {
            get { return initialDirection; }
            set { initialDirection = value; }
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
