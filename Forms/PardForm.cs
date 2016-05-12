using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Models;

namespace Lab3.Forms
{
    public partial class PardForm : Form
    {
        public PardForm()
        {
            InitializeComponent();
        }

        public Point p1;
        public Point p2;
        public Point p3;
        public point p4;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            p1 = new Point(int.Parse(x1.Value.ToString()), int.Parse(y1.Value.ToString()));
            p2 = new Point(int.Parse(x2.Value.ToString()), int.Parse(y2.Value.ToString()));
            p3 = new Point(int.Parse(x3.Value.ToString()), int.Parse(y3.Value.ToString()));
            p4 = new point(int.Parse(x1.Value.ToString()), int.Parse(y1.Value.ToString()), int.Parse(z4.Value.ToString()));
        }
    }
}
