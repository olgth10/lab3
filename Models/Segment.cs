using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    class Segment:Figure2D
    {
        private double Length
        {
            get
            {
                return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            }
            set
            {
                Length = value;
            }
        }

        private new double Space
        {
            get
            {
                return 0;
            }
        }

        private Point p1, p2;

        public Segment(Point P1,Point P2)
        {
            p1 = P1;
            p2 = P2;
            
        }

        public override string ToString()
        {
            return $"Длинна:{Length}";
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, p1, p2);
        }

        public override void Move(int X, int Y)
        {
            p1.X += X;
            p1.Y += Y;
            p2.X += X;
            p2.Y += Y;
        }

        public override void Zoom(double z)
        {
            p1.X = int.Parse((p1.X * z).ToString());
            p1.Y = int.Parse((p1.Y * z).ToString());
            p2.X = int.Parse((p2.X * z).ToString());
            p2.Y = int.Parse((p2.Y * z).ToString());
        }
    }
}
