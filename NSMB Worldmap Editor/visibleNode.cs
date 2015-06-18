using System;
using System.Collections.Generic;
using System.Drawing;

namespace NSMB_Worldmap_Editor
{
    public class visibleNode
    {
        private int positionX, positionY, positionZ, path1, path2, path3, path4, secretPath1, secretPath2, secretPath3, secretPath4, camera, secretCamera;

        public visibleNode(int posX, int posY, int posZ, int p1, int p2, int p3, int p4, int sp1, int sp2, int sp3, int sp4, int c, int sc)
        {
            positionX = posX;
            positionY = posY;
            positionZ = posZ;
            path1 = p1;
            path2 = p2;
            path3 = p3;
            path4 = p4;
            secretPath1 = sp1;
            secretPath2 = sp2;
            secretPath3 = sp3;
            secretPath4 = sp4;
            camera = c;
            secretCamera = sc;
        } 

        public int posX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int posY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        public int posZ
        {
            get { return positionZ; }
            set { positionZ = value; }
        }

        public int p1
        {
            get { return path1; }
            set { path1 = value; }
        }

        public int p2
        {
            get { return path2; }
            set { path2 = value; }
        }

        public int p3
        {
            get { return path3; }
            set { path3 = value; }
        }

        public int p4
        {
            get { return path4; }
            set { path4 = value; }
        }

        public int sp1
        {
            get { return secretPath1; }
            set { secretPath1 = value; }
        }

        public int sp2
        {
            get { return secretPath2; }
            set { secretPath2 = value; }
        }

        public int sp3
        {
            get { return secretPath3; }
            set { secretPath3 = value; }
        }

        public int sp4
        {
            get { return secretPath4; }
            set { secretPath4 = value; }
        }

        public int c
        {
            get { return camera; }
            set { camera = value; }
        }

        public int sc
        {
            get { return secretCamera; }
            set { secretCamera = value; }
        }
    }
}
