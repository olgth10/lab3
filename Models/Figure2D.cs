using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public abstract class Figure2D
    {
        protected double Space;
        protected double Perimeter;
        public abstract void Zoom(double z);
        public abstract void Move(int X, int Y);
        public abstract void Draw(Graphics g,Pen p);
        public abstract override string ToString();        
    }
}
