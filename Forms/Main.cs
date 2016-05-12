using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Lab3.Models;
using Lab3.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Pen p = new Pen(Color.Black);
        private List<Figure2D> ls=new List<Figure2D>();

        private void button1_Click(object sender, EventArgs e)
        {
            SegmentForm seg = new SegmentForm();
            if (seg.ShowDialog() == DialogResult.OK)
            {
                Segment s = new Segment(seg.p1,seg.p2);
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                s.Draw(g, p);
                ls.Add(s);
                listBox1.Items.Add(s.GetType().Name);
                textBox1.Text = s.ToString();
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParmForm parm = new ParmForm();
            if (parm.ShowDialog() == DialogResult.OK)
            {
                Parallelogram pr = new Parallelogram(parm.p1, parm.p2, parm.p3);
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                pr.Draw(g, p);
                ls.Add(pr);
                listBox1.Items.Add(pr.GetType().Name);
                textBox1.Text = pr.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            listBox1.Items.Clear();
            ls.Clear();
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ls[listBox1.SelectedIndex].Zoom(double.Parse(zoom.Value.ToString()));
                pictureBox1.Refresh();
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                foreach(Figure2D f in ls)
                {
                    f.Draw(g, p);
                }
                textBox1.Text = "";
                textBox1.Text = ls[listBox1.SelectedIndex].ToString();
            }
            else
            {
                MessageBox.Show("Выберите фигуру для масштабирования");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = "";
                textBox1.Text = ls[listBox1.SelectedIndex].ToString();
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                pictureBox1.Refresh();
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                ls[listBox1.SelectedIndex].Move(int.Parse(x.Value.ToString()), int.Parse(y.Value.ToString()));
                foreach (Figure2D f in ls)
                {
                    f.Draw(g, p);
                }
            }
            else
            {
                MessageBox.Show("Выберите фигуру для перемещения");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RhombusForm rf = new RhombusForm();
            if (rf.ShowDialog() == DialogResult.OK)
            {
                Rhombus r = new Rhombus(rf.p1, rf.p2, rf.p3);
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                r.Draw(g, p);
                ls.Add(r);
                listBox1.Items.Add(r.GetType().Name);
                textBox1.Text = r.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShRhombusForm srf = new ShRhombusForm();
            if (srf.ShowDialog() == DialogResult.OK)
            {
                ShadedRhombus r = new ShadedRhombus(srf.b,srf.p1, srf.p2, srf.p3);
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                r.Draw(g, p);
                ls.Add(r);
                listBox1.Items.Add(r.GetType().Name);
                textBox1.Text = r.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrapezeForm tf = new TrapezeForm();
            if (tf.ShowDialog() == DialogResult.OK)
            {
                Trapeze t = new Trapeze(tf.p1, tf.p2, tf.p3, tf.p4);
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                t.Draw(g, p);
                ls.Add(t);
                listBox1.Items.Add(t.GetType().Name);
                textBox1.Text = t.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PardForm pdf = new PardForm();
            if (pdf.ShowDialog() == DialogResult.OK)
            {
                Parallelepiped t = new Parallelepiped(pdf.p1, pdf.p2, pdf.p3, pdf.p4);
                Graphics g = pictureBox1.CreateGraphics();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
                t.Draw(g, p);
                ls.Add(t);
                listBox1.Items.Add(t.GetType().Name);
                textBox1.Text = t.ToString();
            }
        }
    }
}
