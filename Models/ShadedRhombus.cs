using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3.Models
{
    class ShadedRhombus:Rhombus
    {
        private SolidBrush b;

        public ShadedRhombus(SolidBrush b1, Point P1, Point P2, Point P3):base(P1,P2,P3)
        {
            if (b1 != null)
            {
                b = b1;
            }
            else
            {
                b = new SolidBrush(Color.Black);
            }            
        }

        public override void Draw(Graphics g, Pen p)
        {
            Image i = Image.FromFile("1.jpg");
            Point[] pi = new Point[4] { p1, p2, new Point(p2.X - (p1.X - p3.X), p2.Y - (p1.Y - p3.Y)), p3 };
            g.FillPolygon(b, pi);
        }

        public override string ToString()
        {
            return base.ToString()+$"\n Цвет: {b.Color.Name}";
        }
    }
}
