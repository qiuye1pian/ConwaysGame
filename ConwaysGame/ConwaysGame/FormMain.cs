using ConwaysGame.Components;
using ConwaysGame.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysGame
{
    public partial class FormMain : Form
    {
        World world;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateWorld_Click(object sender, EventArgs e)
        {
            world = new World(50, 50);
        }

        private void RefreshPanel()
        {
            if (world == null) return;
            this.panel1.Controls.Clear();
            world.Evolution();
            List<DisplayCell> displayCells = new List<DisplayCell>();
            for (int x = 0; x < world.Width; x++)
            {
                for (int y = 0; y < world.Height; y++)
                {
                    displayCells.Add(new DisplayCell(world.GetCell(x, y), x, y));
                }
            }
            panel1.Controls.AddRange(displayCells.ToArray());
            panel1.Refresh();
        }


        private void Next(object sender, EventArgs e)
        {
            RefreshPanel();
        }
    }
    class DisplayCell : Label
    {
        private static readonly int sideLength = 200;

        public DisplayCell(Cell cell, int x, int y)
        {
            this.Width = sideLength;
            this.Height = sideLength;
            this.Left = sideLength * x;
            this.Top = sideLength * y;
            if (cell.Status == CellStatus.Alive)
            {
                this.BackColor = Color.AliceBlue;
            }
            this.Visible = true;
        }


    }
}
