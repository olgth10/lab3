using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    class Rhombus:Parallelogram
    {        
        public Rhombus(Point P1, Point P2, Point P3) : base(P1, P2,P3)
        {

        }

        protected override double Space
        {
            get
            {
                return 2 * Math.Abs(p1.X - p2.X) * Math.Abs(p1.Y - p2.Y);
            }
        }

        public override string ToString()
        {
            return $"Площадь {Space} \n периметр {Perimeter}";
        }
    }
}
