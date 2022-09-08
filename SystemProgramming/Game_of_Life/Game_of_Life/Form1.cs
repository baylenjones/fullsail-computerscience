using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe = new bool[30, 30];
        bool[,] multiverse = new bool[30, 30];

        // Drawing colors
        Color gridColor = Color.Blue;
        Color cellColor = Color.Blue;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        private void Judge(int num, int x, int y)
        {

            if (universe[x, y] == true)
            {
                if(num < 2 || num > 3)
                {
                    multiverse[x, y] = false;
                }
                else { multiverse[x, y] = true; }
            }
            
            if (universe[x, y] == false)
            {
                if(num == 3)
                {
                    multiverse[x, y] = true;
                }
                else { multiverse[x, y] = false; }
            }
            
        }
        private void NextGeneration()
        {
            generations++;
            for(int x = 0; x < universe.GetLength(0); x++)
            {
                for(int y = 0; y < universe.GetLength(1); y++)
                {
                    int num = CountNeighborsToroidal(x,y);
                    Judge(num,x,y);
                }
            }
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            bool[,] temp = universe;
            universe = multiverse;
            multiverse = temp;

            graphicsPanel1.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            float cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            float cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);
            Pen gridPen = new Pen(gridColor, 1);

            Brush cellBrush = new SolidBrush(cellColor);

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                float cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                float cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                float x = e.X / cellWidth;
                float y = e.Y / cellHeight;

                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

                graphicsPanel1.Invalidate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int CountNeighborsToroidal(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    if(xOffset == 0 && yOffset == 0) { continue; }
                    if(xCheck < 0) { xCheck = xLen - 1; }
                    if(yCheck < 0) { yCheck = yLen - 1; }
                    if (xCheck >= xLen) { xCheck = 0; }
                    if (yCheck >= yLen) { yCheck = 0; }
                    if (universe[xCheck, yCheck]) count++;
                }
            }
            return count;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //start
            timer.Enabled = !timer.Enabled;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pause
            timer.Enabled = !timer.Enabled;
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Next
            NextGeneration();
            timer.Enabled = true;
            timer.Enabled = false;
            graphicsPanel1.Invalidate();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //New / Empty
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = false;
                    graphicsPanel1.Invalidate();
                }
            }
            generations = 0;
        }
    }
}
