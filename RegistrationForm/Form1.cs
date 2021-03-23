using System;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(35, 30);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PІN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else
            {
                groupBox1.Controls.Clear();
            }
        }
    }
}