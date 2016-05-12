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
    public partial class RhombusForm : Form
    {
        public RhombusForm()
        {
            InitializeComponent();
        }

        public Point p1;
        public Point p2;
        public Point p3;

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new Point(int.Parse(x1.Value.ToString()), int.Parse(y1.Value.ToString()));
            p2 = new Point(int.Parse(x2.Value.ToString()), int.Parse(y2.Value.ToString()));
            p3 = new Point(int.Parse(x3.Value.ToString()), int.Parse(y3.Value.ToString()));
            if (Math.Pow((p1.X-p2.X), 2) + Math.Pow((p1.Y-p2.Y), 2)==Math.Pow((p1.X-p3.X), 2) + Math.Pow((p1.Y-p3.Y), 2))
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
