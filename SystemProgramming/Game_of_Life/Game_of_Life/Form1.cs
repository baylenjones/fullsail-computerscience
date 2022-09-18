using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // Views
        bool ViewNeighbors = false;
        bool ViewGrid = true;
        bool ViewHUD = false;
        bool ViewToro = true;

        // The universe array
        int universeSize = 30;
        bool[,] universe = new bool[30, 30];
        bool[,] multiverse = new bool[30, 30];

        // Drawing colors
        Color gridColor = Color.Gray;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // intervals count
        int generations = 0;
        int livingCells = 0;

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
            
            bool[,] temp = universe;
            universe = multiverse;
            multiverse = temp;
            livingCells = CountLivingCells();
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            LivingCells.Text = "Living Cells = " + livingCells.ToString();
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
                    if(ViewGrid == true) { e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height); }
                }
            }

            gridPen.Dispose();
            cellBrush.Dispose();

            if(ViewNeighbors == true)
            {
                Font font = new Font("Arial", 20f);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                Rectangle rect = new Rectangle(0, 0, 100, 100);
                int neighbors = 8;

                e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, rect, stringFormat);
            }
            
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
                livingCells = CountLivingCells();
                LivingCells.Text = "Living Cells = " + livingCells.ToString();
                graphicsPanel1.Invalidate();
            }
        }

        // Count Neightbors Torodial
        private int CountNeighborsToroidal(int x, int y)
        {
            if(ViewToro == true)
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
                        if (xOffset == 0 && yOffset == 0) { continue; }
                        if (xCheck < 0) { xCheck = xLen - 1; }
                        if (yCheck < 0) { yCheck = yLen - 1; }
                        if (xCheck >= xLen) { xCheck = 0; }
                        if (yCheck >= yLen) { yCheck = 0; }
                        if (universe[xCheck, yCheck]) count++;
                    }
                }
                return count;
            }
            if(ViewToro == false)
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
                        // if xOffset and yOffset are both equal to 0 then continue
                        if(xOffset == 0 && yOffset == 0) { continue; }
                        // if xCheck is less than 0 then continue
                        if(xCheck < 0) { continue; }
                        // if yCheck is less than 0 then continue
                        if(yCheck < 0) { continue; }
                        // if xCheck is greater than or equal too xLen then continue
                        if(xCheck >= xLen) { continue; }
                        // if yCheck is greater than or equal too yLen then continue
                        if(yCheck >= yLen) { continue; }
                        if (universe[xCheck, yCheck] == true) count++;
                    }
                }
                return count;
            }
            return 0;
        }
        // Count Living Cells
        private int CountLivingCells()
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int y = 0; y < universe.GetLength(0); y++)
            {
                for (int x = 0; x < universe.GetLength(1); x++)
                {
                    if(universe[x,y] == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }


        // Randomize
        private void Randomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    int test = rand.Next(0, 6);
                    if((test % 2) == 0) { universe[x, y] = true; }
                    else { universe[x, y] = false; }
                }
            }
            generations = 0;
            livingCells = CountLivingCells();
            LivingCells.Text = "Living Cells = " + livingCells.ToString();
            graphicsPanel1.Invalidate();
        }
        // New / Empty
        private void Clear_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = false;
                }
            }
            generations = 0;
            livingCells = 0;
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            LivingCells.Text = "Living Cells = " + livingCells.ToString();
            graphicsPanel1.Invalidate();
        }
        // Next
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NextGeneration();
            timer.Enabled = true;
            timer.Enabled = false;
            graphicsPanel1.Invalidate();
        }
        // Pause
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
        // Start
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
        // Cell Color
        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = cellColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cellColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }
        }
        // Background Color
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = graphicsPanel1.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                graphicsPanel1.BackColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }
        }
        // Grid Color
        private void GridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = gridColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                gridColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }
        }
        // Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Right Click Color change
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = cellColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cellColor = dlg.Color;
                graphicsPanel1.Invalidate();
            }
        }
        // Options Tab
        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalDialog dlg = new ModalDialog();

            dlg.ShowDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if(universeSize != dlg.universeSize)
                {
                    universeSize = dlg.universeSize;
                    universe = new bool[universeSize, universeSize];
                    multiverse = new bool[universeSize, universeSize];
                }
                if(timer.Interval != dlg.Miliseconds)
                {
                    timer.Interval = dlg.Miliseconds;
                }
                graphicsPanel1.Invalidate();
            }
        }
        // Load
        private void loadPattern_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.
                    if(row.StartsWith("!") == true) { continue; }

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    if (row.StartsWith("!") == false)
                    {
                        maxHeight++;
                    }
                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                    maxWidth = row.Length;
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                universe = new bool[maxHeight, maxWidth];
                multiverse = new bool[maxHeight, maxWidth];
                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                maxHeight = 0;

                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();
                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row.StartsWith("!") == true) { continue; }

                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    if (row.StartsWith("!") == false)
                    {
                        for (int xPos = 0; xPos < row.Length; xPos++)
                        {
                            // If row[xPos] is a 'O' (capital O) then
                            // set the corresponding cell in the universe to alive.
                            if(row[xPos] == 'O') { universe[xPos, maxHeight] = true; }
                            // If row[xPos] is a '.' (period) then
                            // set the corresponding cell in the universe to dead.
                            if (row[xPos] == '.') { universe[xPos, maxHeight] = false; }

                        }
                    }
                    maxHeight++;
                }

                // Close the file.
                reader.Close();
            }
            graphicsPanel1.Invalidate();
        }
        // Save
        private void savePattern_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";


            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.
                writer.WriteLine("!This is my comment.");

                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(0); y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(1); x++)
                    {
                        // If the universe[x,y] is alive then append 'O' (capital O)
                        // to the row string.
                        if (universe[x,y] == true) { currentRow += 'O'; }

                        // Else if the universe[x,y] is dead then append '.' (period)
                        // to the row string.
                        else if (universe[x,y] == false) { currentRow += '.'; }
                    }

                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                    writer.WriteLine(currentRow);
                }

                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }
        // View Grid
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGrid = !ViewGrid;
            gridToolStripMenuItem.Checked = !gridToolStripMenuItem.Checked;
            graphicsPanel1.Invalidate();
        }
        // View Living Neighbors
        private void livingNeighborsCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewNeighbors = !ViewNeighbors;
            livingNeighborsCountToolStripMenuItem.Checked = !livingNeighborsCountToolStripMenuItem.Checked;
            graphicsPanel1.Invalidate();
        }
        // View HUD
        private void hUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHUD = !ViewHUD;
            hUDToolStripMenuItem.Checked = !hUDToolStripMenuItem.Checked;
            graphicsPanel1.Invalidate();
        }
        // View Torodial Toggle
        private void torodialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewToro = !ViewToro;
            torodialToolStripMenuItem.Checked = !torodialToolStripMenuItem.Checked;
            graphicsPanel1.Invalidate();
        }
    }
}
