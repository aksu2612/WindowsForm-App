using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartiys_
{
    public partial class Gorevler : Form
    {
        public Gorevler()
        {
            InitializeComponent();
        }

        private void DrawIt()
        {
             
            Point[] points = {new Point(40, 60),new Point(50, 70),new Point(30, 90)};

            GraphicsPath path = new GraphicsPath();

            path.StartFigure(); // Start the first figure.
            path.AddArc(175, 50, 50, 50, 0, -180);
            path.AddLine(100, 0, 250, 20);
            // First figure is not closed.

            path.StartFigure(); // Start the second figure.
            path.AddLine(50, 20, 5, 90);
            path.AddCurve(points, 3);
            path.AddLine(50, 150, 150, 180);
            path.CloseFigure(); // Second figure is closed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawIt();

        }

        private void Gorevler_Load(object sender, EventArgs e)
        {

        }
    }
}
