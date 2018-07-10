using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameOfLife
{
    
    public partial class Form_Principal : Form
    {
        private Board board = new Board();
        private static Thread drawing;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            board.NewRandomBoard();
            drawing = new Thread(new ThreadStart(this.Drawing));
            drawing.IsBackground = true;
            drawing.Start();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            board.NewRandomBoard();
        }

        private void Drawing()
        {
            while (true)
            {
                board.NextBoard();
                Bitmap bipmap = new Bitmap(500, 500);
                Graphics graphics = Graphics.FromImage(bipmap);
                graphics.FillRectangle(Brushes.White, 0, 0, 500, 500);
                for (int x = 0; x < 50; x++)
                {
                    for (int y = 0; y < 50; y++)
                    {
                        Cell cell = board.GetCellAt(x, y);
                        if (cell.IsAlive())
                        {
                            graphics.FillRectangle(Brushes.Green, cell.GetX() * 10, cell.GetY() * 10, 10, 10);
                        }
                        else
                        {
                            graphics.FillRectangle(Brushes.Black, cell.GetX() * 10, cell.GetY() * 10, 10, 10);
                        }
                    }
                }
                pictureBox_LifeBoard.BeginInvoke((MethodInvoker)delegate
                {
                    pictureBox_LifeBoard.Image = bipmap;
                    pictureBox_LifeBoard.Refresh();
                });
                Thread.Sleep(100);
            }
        }

    }
}
