using System;

using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NSMB_Worldmap_Editor.Controls
{
    public partial class EditorControl : UserControl
    {

        private Rectangle ViewablePixels;
        public int areaWidth = 4000, areaHeight = 2000;

        public int selectedNode;
        public bool nodeSelected;

        public NodeEditor ne;

        public List<visibleNode> visibleNodeList;
        Bitmap nodeImg = ResizeBitmap(Properties.Resources.NormalNode, 36, 36);

        public List<frame> frameList;
        public int highlightedFrame;
    
        public EditorControl()
        {
            InitializeComponent();

            ViewablePixels = new Rectangle();
            UpdateScrollbars();
        }

        #region Render

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            if (visibleNodeList != null)
            {
                e.Graphics.TranslateTransform(-ViewablePixels.X, -ViewablePixels.Y);
                drawGrid(e);
                drawNodes(e);
                drawSelection(e);
            }

            if (frameList != null)
            {
                drawFrames(e);
            }
        }

        private void drawGrid(PaintEventArgs e)
        {
            e.Graphics.DrawLine(
                    new Pen(Color.LightGray, 4),
                    0, areaHeight / 2,
                    areaWidth, areaHeight / 2);

            e.Graphics.DrawLine(
                    new Pen(Color.LightGray, 4),
                    areaWidth / 2, 0,
                    areaWidth / 2, areaHeight);

            for (int x = 0; x < areaWidth/100; x++)
            {
                for (int y = 0; y < areaHeight/100; y++)
                {
                    e.Graphics.DrawRectangle(Pens.LightGray, x * 100, y * 100, 100, 100);
                }
            }
        }

        private void drawNodes(PaintEventArgs e)
        {
            foreach (visibleNode n in visibleNodeList)
            {
                e.Graphics.DrawImage(nodeImg, n.posX + areaWidth / 2 - nodeImg.Size.Width / 2, n.posY + areaHeight / 2 - nodeImg.Size.Height / 2);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                string nbr = visibleNodeList.IndexOf(n).ToString();
                e.Graphics.DrawString(nbr, new Font("Tahoma", 14), Brushes.White, new Rectangle(n.posX + areaWidth / 2 - nodeImg.Size.Width / 2,
                                                                                                n.posY + areaHeight / 2 - nodeImg.Size.Height / 2,
                                                                                                nodeImg.Size.Width, nodeImg.Size.Height), stringFormat);
            }
        }

        private void drawSelection(PaintEventArgs e)
        {
            if (nodeSelected == true)
            {
                e.Graphics.DrawRectangle(Pens.Red, visibleNodeList[selectedNode].posX + areaWidth / 2 - nodeImg.Size.Width / 2, visibleNodeList[selectedNode].posY + areaHeight / 2 - nodeImg.Size.Height / 2, nodeImg.Size.Width, nodeImg.Size.Height);
            }
        }

        private void drawFrames(PaintEventArgs e)
        {
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            foreach (frame f in frameList)
            {
                if (highlightedFrame != frameList.IndexOf(f)) e.Graphics.FillEllipse(Brushes.Blue, f.x + areaWidth / 2 - 3, f.y + areaHeight / 2 - 3, 6, 6);
            }
            e.Graphics.FillEllipse(Brushes.Red, frameList[highlightedFrame].x + areaWidth / 2 - 3, frameList[highlightedFrame].y + areaHeight / 2 - 3, 6, 6);
        }

        public void redraw()
        {
            DrawingArea.Invalidate();
        }

        #endregion


        #region Scrolling/Draging

        private bool scrollingDrag;
        private int scrollingDragStartX, scrollingDragStartY;

        private bool drag;
        private int dragStartX, dragStartY;

        private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (visibleNodeList != null)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Middle || e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Alt)
                {
                    scrollingDragStartX = e.X;
                    scrollingDragStartY = e.Y;
                    scrollingDrag = true;
                }

                if (e.Button == MouseButtons.Left)
                {
                    dragStartX = e.X;
                    dragStartY = e.Y;
                    drag = true;

                    nodeSelected = false;

                    int nodeX = e.X + ViewablePixels.X - areaWidth / 2;
                    int nodeY = e.Y + ViewablePixels.Y - areaHeight / 2;

                    foreach (visibleNode n in visibleNodeList)
                    {
                        if ((nodeX - nodeImg.Size.Width / 2 <= n.posX && nodeX + nodeImg.Size.Height / 2 >= n.posX)
                            && (nodeY - nodeImg.Size.Height / 2 <= n.posY && nodeY + nodeImg.Size.Height / 2 >= n.posY))
                        {
                            selectedNode = visibleNodeList.IndexOf(n);
                            nodeSelected = true;
                        }
                    }

                    ne.nodeChanged(selectedNode, nodeSelected);
                    DrawingArea.Invalidate();
                }
            }
            this.Focus();
        }

        private int oldMouseX, oldMouseY;

        private void DrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (scrollingDrag)
            {
                int NewX = e.X;
                int NewY = e.Y;
                int xDelta = NewX - scrollingDragStartX;
                int yDelta = NewY - scrollingDragStartY;
                ScrollEditor(new Point(hScrollBar.Value - xDelta, vScrollBar.Value - yDelta));
                redraw();
                scrollingDragStartX = NewX;
                scrollingDragStartY = NewY;
            }

            if (drag && nodeSelected)
            {
                visibleNode oldNode = visibleNodeList[selectedNode];
                int oldNodeX = visibleNodeList[selectedNode].posX;
                int oldNodeY = visibleNodeList[selectedNode].posY;
                int newNodeX = oldNode.posX + e.X - oldMouseX;
                int newNodeY = oldNode.posY + e.Y - oldMouseY;
                if (newNodeX > areaWidth/2) newNodeX = areaWidth/2;
                if (newNodeX < -areaWidth/2) newNodeX = -areaWidth/2;
                if (newNodeY > areaHeight/2) newNodeY = areaHeight/2;
                if (newNodeY < -areaHeight/2) newNodeY = -areaHeight/2;
                visibleNodeList[selectedNode] = new visibleNode(newNodeX, newNodeY, oldNode.posZ, oldNode.p1, oldNode.p2, oldNode.p3, oldNode.p4, oldNode.sp1, oldNode.sp2, oldNode.sp3, oldNode.sp4, oldNode.c, oldNode.sc);
                redraw();
                ne.nodeChanged(selectedNode, true);
            }

            oldMouseX = e.X;
            oldMouseY = e.Y;
        }

        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            scrollingDrag = false;
            drag = false;
        }

        public void ScrollEditor(Point NewPosition)
        {
            hScrollBar.Value = Math.Max(hScrollBar.Minimum, Math.Min(hScrollBar.Maximum, NewPosition.X));
            vScrollBar.Value = Math.Max(vScrollBar.Minimum, Math.Min(vScrollBar.Maximum, NewPosition.Y));
        }

        public void ScrollEditorMiddle()
        {
            ScrollEditor(new Point(areaWidth/2 - (this.Width - 15)/2, areaHeight/2 - (this.Height - 15)/2));
        }

        private void UpdateScrollbars()
        {
            hScrollBar.Maximum = areaWidth;
            hScrollBar.LargeChange = DrawingArea.Width;
            hScrollBar.Value = Math.Min(hScrollBar.Value, Math.Max(hScrollBar.Minimum, hScrollBar.Maximum - hScrollBar.LargeChange));
            hScrollBar.Enabled = hScrollBar.Maximum > hScrollBar.LargeChange;

            vScrollBar.Maximum = areaHeight;
            vScrollBar.LargeChange = DrawingArea.Height;
            vScrollBar.Value = Math.Min(vScrollBar.Value, Math.Max(vScrollBar.Minimum, vScrollBar.Maximum - vScrollBar.LargeChange));
            vScrollBar.Enabled = vScrollBar.Maximum > vScrollBar.LargeChange;

            ViewablePixels.X = (int)(hScrollBar.Value);
            ViewablePixels.Y = (int)(vScrollBar.Value);
            ViewablePixels.Width = (int)Math.Ceiling((float)DrawingArea.Width);
            ViewablePixels.Height = (int)Math.Ceiling((float)DrawingArea.Height);

        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateScrollbars();
            DrawingArea.Invalidate();
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateScrollbars();
            DrawingArea.Invalidate();
        }

        private void Editor2D_SizeChanged(object sender, EventArgs e)
        {
            DrawingArea.Invalidate();
        }
        #endregion

        private static Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
                g.DrawImage(sourceBMP, 0, 0, width, height);
            return result;
        }
        
    }
}
