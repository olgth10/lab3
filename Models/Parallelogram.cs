using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    class Parallelogram:Figure2D
    {
        protected Point p1;
        protected Point p2;
        protected Point p3;       

        public Parallelogram(Point P1,Point P2,Point P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }

        protected new virtual double Space
        {
            get
            {
                //return Math.Sqrt(Math.Pow((p1.X-p3.X),2)+Math.Pow((p1.Y-p3.Y),2))*Math.Sqrt(Math.Pow((p1.X-p2.X),2)+Math.Pow((p1.Y-p2.Y),2));
                return Math.Abs(p1.Y - p3.Y) * Math.Abs(p2.X - p1.X);
            }
        }

        protected new double Perimeter
        {
            get
            {
                return 2 * Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2)) +2 * Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
            }
        }

        public override void Draw(Graphics g, Pen p)
        {
            Image i = Image.FromFile("1.jpg");
            Point[] pi = new Point[4] { p1, p2, new Point(p2.X-(p1.X-p3.X),p2.Y-(p1.Y-p3.Y)) , p3};
            g.DrawPolygon(p, pi);
        }

        public override void Move(int X,int Y)
        {
            p1.X += X;
            p1.Y += Y;
            p2.X += X;
            p2.Y += Y;
            p3.X += X;
            p3.Y += Y; 
        }

        public override void Zoom(double z)
        {
            p1.X = int.Parse(Math.Truncate(p1.X * z).ToString());
            p1.Y = int.Parse(Math.Truncate(p1.Y * z).ToString());
            p2.X = int.Parse(Math.Truncate(p2.X * z).ToString());
            p2.Y = int.Parse(Math.Truncate(p2.Y * z).ToString());
            p3.X = int.Parse(Math.Truncate(p3.X * z).ToString());
            p3.Y = int.Parse(Math.Truncate(p3.Y * z).ToString());
        }

        public override string ToString()
        {
            return $"Площадь {Space} \n периметр {Perimeter}";
        }
    }
}
