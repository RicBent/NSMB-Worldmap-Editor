using System;
using System.Collections.Generic;
using System.Drawing;

namespace NSMB_Worldmap_Editor
{
    public class dataNode
    {
        private int levelArea, levelIcon, worldmapSettings;
        private byte[] pointer;

        public dataNode(int area, int icon, int settings, byte[] ptr)
        {
            levelArea = area;
            levelIcon = icon;
            worldmapSettings = settings;
            pointer = ptr;
        }

        public int area
        {
            get { return levelArea; }
            set { levelArea= value; }
        }

        public int icon
        {
            get { return levelIcon; }
            set { levelIcon = value; }
        }

        public int settings
        {
            get { return worldmapSettings; }
            set { worldmapSettings = value; }
        }

        public byte[] ptr
        {
            get { return pointer; }
            set { pointer = value; }
        }
    }
}