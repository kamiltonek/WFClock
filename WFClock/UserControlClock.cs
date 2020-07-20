using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClock
{
    public partial class UserControlClock : UserControl
    {
        Graphics graphic;
        private Color clockColor;
        public Color ClockColor { get => clockColor; set => clockColor = value; }
        private bool isDigital;
        public bool IsDigital 
        { 
            get => isDigital;
            set {
                isDigital = value;
                if (isDigital)
                {
                    labelDigitalClock.Visible = true;
                    pictureBoxAnalog.Visible = false;
                    cyfrowyToolStripMenuItem.Enabled = false;
                    analogowyToolStripMenuItem.Enabled = true;
                    czcionkaToolStripMenuItem.Enabled = true;
                }
                else
                {
                    labelDigitalClock.Visible = false;
                    pictureBoxAnalog.Visible = true;
                    cyfrowyToolStripMenuItem.Enabled = true;
                    analogowyToolStripMenuItem.Enabled = false;
                    czcionkaToolStripMenuItem.Enabled = false;
                }
            } 
        }
        public Point Center
        {
            get => new Point(pictureBoxAnalog.Width / 2,
                             pictureBoxAnalog.Height / 2);
        }
        public int Radious
        {
            get => (int)(Math.Min(pictureBoxAnalog.Width, 
                                  pictureBoxAnalog.Height) / 2 * 0.95);
        }
       

        public UserControlClock()
        {
            InitializeComponent();
            IsDigital = true;
            ClockColor = Color.White;

            pictureBoxAnalog_SizeChanged(null, null);
        }

        private void Repaint()
        {
            if (IsDigital)
            {
                labelDigitalClock.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                graphic.Clear(BackColor);
                graphic.FillEllipse(new SolidBrush(ClockColor),
                                    Center.X - Radious,
                                    Center.Y - Radious,
                                    Radious * 2,
                                    Radious * 2);
                graphic.DrawEllipse(new Pen(ForeColor, 5),
                                    Center.X - Radious,
                                    Center.Y - Radious,
                                    Radious * 2,
                                    Radious * 2);
                double angleSecond = (DateTime.Now.Second - 15 + DateTime.Now.Millisecond / 1000.0) * 2 * Math.PI / 60;
                double angleMinute = (DateTime.Now.Minute - 15 + DateTime.Now.Second / 60.0) * 2 * Math.PI / 60;
                double angleHour = (DateTime.Now.Hour - 3 * DateTime.Now.Minute / 60) * 2 * Math.PI / 12;

                drawLine(angleSecond, 0.0, 0.9, 1);
                drawLine(angleMinute, 0.0, 0.7, 3);
                drawLine(angleHour, 0.0, 0.5, 5);

                for(int i = 0; i < 60; i++)
                {
                    double angle = 2 * Math.PI / 60 * i;
                    if(i % 5 == 0)
                    {
                        drawLine(angle, 0.85, 1.0, 3);
                    }
                    else
                    {
                        drawLine(angle, 0.9, 1.0, 1);
                    }
                }

                pictureBoxAnalog.Refresh();
            }
        }
        private void drawLine(double angle, double length1, double length2, int width)
        {
            Point p1 = getPoint(angle, length1);
            Point p2 = getPoint(angle, length2);

            Pen myPen = new Pen(ForeColor, width);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            graphic.DrawLine(myPen,
                             Center.X + p1.X,
                             Center.Y + p1.Y,
                             Center.X + p2.X,
                             Center.Y + p2.Y);

        }

        private Point getPoint(double angle, double length)
        {
            Point p = new Point();
            p.X = (int)(Radious * length * Math.Cos(angle));
            p.Y = (int)(Radious * length * Math.Sin(angle));
            return p;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Repaint();
        }

        private void pictureBoxAnalog_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxAnalog.Image = new Bitmap(pictureBoxAnalog.Width, pictureBoxAnalog.Height);
            graphic = Graphics.FromImage(pictureBoxAnalog.Image);
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Repaint();
        }

        private void cyfrowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDigital = true;
            Repaint();
        }

        private void analogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsDigital = false;
            Repaint();
        }

        private void tłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.Color = BackColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
            Repaint();
        }

        private void tarczaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.Color = ClockColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ClockColor = colorDialog.Color;
            }
            Repaint();
        }

        private void czcionkaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog.Color = ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ForeColor = colorDialog.Color;
            }
            Repaint();
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = labelDigitalClock.Font;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                labelDigitalClock.Font = fontDialog.Font;
            }
        }
    }
}
