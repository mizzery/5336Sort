using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Sort
{
    public partial class ResF : Form
    {
        public ResF()
        {
            InitializeComponent();
        }
        public int Type = 0;
        public int[] mass;
        public int[] mass1;
        private void ResF_Load(object sender, EventArgs e)
        {
            if (Type == 0)
            {
                Type0Sort(true);
                Type0Sort(false);
            } 
            if (Type == 1)
            {
                Type1Sort(true);
                Type1Sort(false);
            }
        }
        void Type0Sort(bool write)
        {
            mass1 = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
                mass1[i] = mass[i];
            if (write)
            {
                MemoryStream ms = new MemoryStream();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                bool per = true;
                while (per)
                {
                    per = false;
                    for (int i = 0; i < mass1.Length - 1; i++)
                    {
                        if (mass1[i] > mass1[i + 1])
                        {
                            int temp = mass1[i];
                            mass1[i] = mass1[i + 1];
                            mass1[i + 1] = temp;
                            per = true;
                            for (int j = 0; j < mass1.Length; j++)
                            {
                                if (j == i || j == i + 1)
                                    ms.Write(Encoding.UTF8.GetBytes("<font color='red'>" + mass1[j].ToString() + "</font> "), 0, Encoding.UTF8.GetBytes("<font color='red'>" + mass1[j].ToString() + "</font> ").Length);
                                else
                                    ms.Write(Encoding.UTF8.GetBytes(mass1[j].ToString() + " "), 0, Encoding.UTF8.GetBytes(mass1[j].ToString() + " ").Length);
                            }
                            ms.Write(Encoding.UTF8.GetBytes("<br>"), 0, Encoding.UTF8.GetBytes("<br>").Length);
                        }
                    }
                }
                sw.Stop();
                label3.Text = sw.ElapsedTicks.ToString() + " тиков;   " + sw.ElapsedMilliseconds.ToString() + " милисекунд";
                ms.Position = 0;
                webBrowser1.DocumentStream = ms;
            }
            else
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                bool per = true;
                while (per)
                {
                    per = false;
                    for (int i = 0; i < mass1.Length - 1; i++)
                    {
                        if (mass1[i] > mass1[i + 1])
                        {
                            int temp = mass1[i];
                            mass1[i] = mass1[i + 1];
                            mass1[i + 1] = temp;
                            per = true;
                        }
                    }
                }
                sw.Stop();
                label4.Text = sw.ElapsedTicks.ToString() + " тиков;   " + sw.ElapsedMilliseconds.ToString() + " милисекунд";
            }
        }
        void Type1Sort(bool write)
        {
            if(write)
            {
                MemoryStream ms = new MemoryStream();
                mass1 = new int[mass.Length];
                for (int i = 0; i < mass.Length; i++)
                    mass1[i] = mass[i];
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int p1, p2, p3, inc, j;
                p1 = p2 = p3 = 1;
                int[] seq = new int[mass1.Length];
                int s = -1;
                do
                {
                    if (++s % 2 == 1)
                    {
                        seq[s] = 8 * p1 - 6 * p2 + 1;
                    }
                    else
                    {
                        seq[s] = 9 * p1 - 9 * p3 + 1;
                        p2 *= 2;
                        p3 *= 2;
                    }
                    p1 *= 2;
                } while (3 * seq[s] < mass1.Length);
                if (s > 0)
                    --s;
                else
                    s = 0;
                while (s >= 0)
                {
                    inc = seq[s--];
                    for (int i = inc; i < mass1.Length; i++)
                    {
                        int q1, q2;
                        int temp = mass1[i];
                        q1 = i;
                        bool per = false;
                        for (j = i - inc; (j >= 0) && (mass1[j] > temp); j -= inc)
                        {
                            mass1[j + inc] = mass1[j];
                            per = true;
                        }
                        mass1[j + inc] = temp;
                        q2 = j + inc;
                        if (per)
                        {
                            for (int k = 0; k < mass1.Length; k++)
                                if(k == q1 || k == q2)
                                    ms.Write(Encoding.UTF8.GetBytes("<font color='red'>" + mass1[k].ToString() + "</font> "), 0, Encoding.UTF8.GetBytes("<font color='red'>" + mass1[k].ToString() + "</font> ").Length);
                                else
                                    ms.Write(Encoding.UTF8.GetBytes(mass1[k].ToString() + " "), 0, Encoding.UTF8.GetBytes(mass1[k].ToString() + " ").Length);
                            ms.Write(Encoding.UTF8.GetBytes("<br>"), 0, Encoding.UTF8.GetBytes("<br>").Length);
                        }
                    }
                }
                sw.Stop();
                label3.Text = sw.ElapsedTicks.ToString() + " тиков;   " + sw.ElapsedMilliseconds.ToString() + " милисекунд";
                ms.Position = 0;
                webBrowser1.DocumentStream = ms;
            }
            else
            {
                mass1 = new int[mass.Length];
                for (int i = 0; i < mass.Length; i++)
                    mass1[i] = mass[i];
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int p1, p2, p3, inc, j;
                p1 = p2 = p3 = 1;
                int[] seq = new int[mass1.Length];
                int s = -1;
                do
                {
                    if(++s % 2 == 1)
                    {
                        seq[s] = 8 * p1 - 6 * p2 + 1;
                    }
                    else
                    {
                        seq[s] = 9 * p1 - 9 * p3 + 1;
                        p2 *= 2;
                        p3 *= 2;
                    }
                    p1 *= 2;
                } while (3 * seq[s] < mass1.Length);
                if (s > 0)
                    --s;
                else
                    s = 0;
                while(s >= 0)
                {
                    inc = seq[s--];
                    for(int i = inc; i<mass1.Length;i++)
                    {
                        int temp = mass1[i];
                        for (j = i - inc; (j >= 0) && (mass1[j] > temp); j -= inc)
                        {
                            mass1[j + inc] = mass1[j];
                        }
                        mass1[j + inc] = temp;
                    }
                }
                sw.Stop();
                label4.Text = sw.ElapsedTicks.ToString() + " тиков;   " + sw.ElapsedMilliseconds.ToString() + " милисекунд";
            }
        }
    }
}
