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
    public partial class TrapezeForm : Form
    {
        public Point p1;
        public Point p2;
        public Point p3;
        public Point p4;

        public TrapezeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new Point(int.Parse(x1.Value.ToString()), int.Parse(y1.Value.ToString()));
            p2 = new Point(int.Parse(x2.Value.ToString()), int.Parse(y2.Value.ToString()));
            p3 = new Point(int.Parse(x3.Value.ToString()), int.Parse(y3.Value.ToString()));
            p4 = new Point(int.Parse(x4.Value.ToString()), int.Parse(y4.Value.ToString()));
            if (Trapeze.isParallel(p1,p2,p3, p4))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите данные для ромба!");
            }
        }
    }
}
