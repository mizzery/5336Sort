using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mass;
        private void B1_Click(object sender, EventArgs e)
        {
            ResF f = new ResF();
            f.Owner = this;
            f.Type = 0;
            f.mass = mass;
            f.vv = checkBox1.Checked;
            f.Show();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ResF f = new ResF();
            f.Owner = this;
            f.Type = 1;
            f.mass = mass;
            f.vv = checkBox1.Checked;
            f.Show();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            ResF f = new ResF();
            f.Owner = this;
            f.Type = 2;
            f.mass = mass;
            f.vv = checkBox1.Checked;
            f.Show();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            ResF f = new ResF();
            f.Owner = this;
            f.Type = 3;
            f.mass = mass;
            f.vv = checkBox1.Checked;
            f.Show();
        }

        private void GRN_Click(object sender, EventArgs e)
        {
            int Count;
            if (int.TryParse(TBGRNC.Text, out Count))
            {
                TBGRN.Text = "";
                mass = new int[Count];
                Random r = new Random();
                for (int i = 0; i < Count; i++)
                {
                    mass[i] = r.Next(255);
                    TBGRN.Text += mass[i].ToString() + " ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Count;
            if (int.TryParse(TBGRNC.Text, out Count))
            {
                TBGRN.Text = "";
                mass = new int[Count];
                for (int i = 0; i < Count; i++)
                {
                    mass[i] = i;
                    TBGRN.Text += mass[i].ToString() + " ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Count;
            if (int.TryParse(TBGRNC.Text, out Count))
            {
                TBGRN.Text = "";
                mass = new int[Count];
                for (int i = 0, j = Count - 1; i < Count; i++, j--)
                {
                    mass[i] = j;
                    TBGRN.Text += mass[i].ToString() + " ";
                }
            }
        }
    }
}
