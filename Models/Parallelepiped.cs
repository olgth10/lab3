using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class point
    {
        private int X;
        private int Y;
        public int Z;

        public point(int x,int y,int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point to2D()
        {
            return new Point(int.Parse(Math.Truncate(0.5 * Z).ToString()),int.Parse(Math.Truncate(0.5 * Z).ToString()));
        }
    }
    class Parallelepiped:Parallelogram
    {
        private Point po;
        private point p;

        public double Volume
        {
            get
            {
                return p.Z * Space;
            }
        }

        public new double Perimeter
        {
            get
            {
                return 2 * (2 * Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2)) + 2 * Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2))) + 4 * p.Z;
            }
        }

        public Parallelepiped(Point P1,Point P2,Point P3,point p4) : base(P1, P2, P3)
        {
            po = p4.to2D();
            p = p4;
        }

        public override void Zoom(double z)
        {
            base.Zoom(z);
            po.X = int.Parse(Math.Truncate(po.X * z).ToString());
            po.Y = int.Parse(Math.Truncate(po.Y * z).ToString());
        }

        public override void Draw(Graphics g,Pen p)
        {
            Image i = Image.FromFile("1.jpg");
            Point[] pi = new Point[4] { p1, p2, new Point(p2.X - (p1.X - p3.X), p2.Y - (p1.Y - p3.Y)), p3 };
            g.DrawPolygon(p, pi);
            for (int j = 0; j < pi.Length; j++)
            {
                g.DrawLine(p, pi[j], new Point(pi[j].X, pi[j].Y + po.Y));
                pi[j].Y += po.Y;
            }
            g.DrawPolygon(p, pi);
        }

        public override string ToString()
        {
            return $"Объём {Volume} \n периметр {Perimeter}";
        }
    }
}
