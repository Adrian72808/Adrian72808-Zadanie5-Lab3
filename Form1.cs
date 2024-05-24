using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 2);

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            int amplitude = height / 4;
            int offsetX = 0;
            int offsetY = height / 2;

            // Tabela punktów dla sinusoidy
            PointF[] points = new PointF[width];

            for (int x = 0; x < width; x++)
            {
                //Pbliczanie wartości y dla x przy pomocy fukcji sisus
                float y = (float)(amplitude * Math.Sin((x + offsetX) * 2 * Math.PI / width) + offsetY);
                points[x] = new PointF(x, y);
            }
            // Rysowanie sinusoidy 
            g.DrawLines(pen, points);
        }
    }
}