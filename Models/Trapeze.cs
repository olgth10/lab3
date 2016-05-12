using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3.Models
{
    class Trapeze:Figure2D
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;

        public Trapeze(Point P1,Point P2, Point P3, Point P4)
        {
            p1 = P1;
            p2 = P2;
            p3 = P4;
            p4 = P3;
        }

        public new double Space
        {
            get
            {
                return (p1.Y - p3.Y) * (p3.X - p4.X)/2;  
            }
        }

        public new double Perimeter
        {
            get
            {
                return Math.Abs(p2.X - p1.X) + Math.Abs(p4.X - p3.X) + Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2)) + Math.Sqrt(Math.Pow((p2.X - p4.X), 2) + Math.Pow((p2.Y - p4.Y), 2));
            }
        }

        public static bool isParallel(Point p1,Point p2, Point p3, Point p4)
        {
            if ((Math.Abs(p2.Y - p1.Y) / Math.Abs(p2.X - p1.X) == Math.Abs(p4.Y - p3.Y) / Math.Abs(p4.X - p3.Y)) || (Math.Abs(p3.Y - p1.Y) / Math.Abs(p3.X - p1.X) == Math.Abs(p4.Y - p2.Y) / Math.Abs(p4.X - p2.Y)) || (Math.Abs(p2.Y - p3.Y) / Math.Abs(p2.X - p3.X) == Math.Abs(p4.Y - p1.Y) / Math.Abs(p4.X - p1.Y)))
            {
                return true;
            }
            return false;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Image i = Image.FromFile("1.jpg");
            Point[] pi = new Point[4] { p1, p2, p3, p4 };
            g.DrawPolygon(p, pi);
        }

        public override void Move(int X, int Y)
        {
            p1.X += X;
            p1.Y += Y;
            p2.X += X;
            p2.Y += Y;
            p3.X += X;
            p3.Y += Y;
            p4.X += X;
            p4.Y += Y;
        }

        public override void Zoom(double z)
        {
            p1.X = int.Parse(Math.Truncate(p1.X * z).ToString());
            p1.Y = int.Parse(Math.Truncate(p1.Y * z).ToString());
            p2.X = int.Parse(Math.Truncate(p2.X * z).ToString());
            p2.Y = int.Parse(Math.Truncate(p2.Y * z).ToString());
            p3.X = int.Parse(Math.Truncate(p3.X * z).ToString());
            p3.Y = int.Parse(Math.Truncate(p3.Y * z).ToString());
            p4.X = int.Parse(Math.Truncate(p4.X * z).ToString());
            p4.Y = int.Parse(Math.Truncate(p4.Y * z).ToString());
        }

        public override string ToString()
        {
            return $"Площадь:{Space} \n периметр:{Perimeter}";
        }
    }
}
