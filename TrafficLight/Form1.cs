using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TrafficLight
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

            // Create sky background
            using (LinearGradientBrush skyBrush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),
                Color.CornflowerBlue, Color.SkyBlue, LinearGradientMode.Vertical))
            {
                g.FillRectangle(skyBrush, 0, 0, this.Width, this.Height);
            }

            // x Point for the Ellipses
            int x = 165;

            // Ellipse radius
            int rSize = 50;

            g.FillRectangle(Brushes.Black, 150, 50, 80, 250);

            // ================= Ellipses (Red, Yellow, Green) =======================
            g.FillEllipse(Brushes.Red, x, 60, rSize, rSize);
            g.FillEllipse(Brushes.Yellow, x, 130, rSize, rSize);
            g.FillEllipse(Brushes.Green, x, 200, rSize, rSize);
            // =====================================================================

            g.FillRectangle(Brushes.Gray, 185, 300, 10, 150);

            g.FillRectangle(Brushes.SaddleBrown, 0, 450, this.Width, 50);
        }
    }
}
