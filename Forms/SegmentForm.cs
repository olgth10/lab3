using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Forms
{
    public partial class SegmentForm : Form
    {
        public Point p1;
        public Point p2;

        public SegmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new Point(int.Parse(x1.Value.ToString()), int.Parse(y1.Value.ToString()));
            p2 = new Point(int.Parse(x2.Value.ToString()), int.Parse(y2.Value.ToString()));
            DialogResult = DialogResult.OK;
        }
    }
}
