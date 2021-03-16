using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_New_Individual_v7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Visible || label3.Visible)
            {
                if (label1.Visible && label3.Visible)
                {
                    label1.Visible = false;
                    label3.Visible = false;
                }
                else if (label1.Visible)
                {
                    label1.Visible = false;
                    label3.Visible = true;
                }
                else
                {
                    label1.Visible = true;
                    label3.Visible = false;
                }
            }
            else
            {
                label1.Visible = true;
                label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Visible || label2.Visible)
            {
                if (label1.Visible && label2.Visible)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                }
                else if (label1.Visible)
                {
                    label1.Visible = false;
                    label2.Visible = true;
                }
                else
                {
                    label1.Visible = true;
                    label2.Visible = false;
                }
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Visible || label4.Visible)
            {
                if (label2.Visible && label4.Visible)
                {
                    label2.Visible = false;
                    label4.Visible = false;
                }
                else if (label2.Visible)
                {
                    label2.Visible = false;
                    label4.Visible = true;
                }
                else
                {
                    label2.Visible = true;
                    label4.Visible = false;
                }
            }
            else
            {
                label2.Visible = true;
                label4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Visible || label4.Visible)
            {
                if (label3.Visible && label4.Visible)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                }
                else if (label3.Visible)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
                else
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
            }
        }
    }
}