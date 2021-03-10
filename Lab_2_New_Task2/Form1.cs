using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_2_New_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeOpacity();
        }

        private void ChangeOpacity()
        {
            if (Opacity != 1)
            {
                Opacity = 1;
            }
            else
            {
                Opacity = 0.25;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeBGColor();
        }

        private static void ChangeBGColor()
        {
            if (ActiveForm.BackColor == DefaultBackColor)
            {
                ActiveForm.BackColor = Color.Chartreuse;
            }
            else
            {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxHello();
        }

        private void MessageBoxHello()
        {
            MessageBox.Show(
                "Hello World!", 
                "Повідомлення", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Я супермегакнопка,\n i цього мене не позбавиш!", 
                "Повідомлення", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.MouseClick += changeOpacity();
            }
            else
            {
                button4.MouseClick -= changeOpacity();
            }
        }

        private MouseEventHandler changeOpacity()
        {
            return (o, args) => ChangeOpacity();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.MouseClick += changeBackColor();
            }
            else
            {
                button4.MouseClick += changeBackColor();
            }
        }

        private static MouseEventHandler changeBackColor()
        {
            return (o, args) => ChangeBGColor();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button4.MouseClick += messageBoxHello();
            }
            else
            {
                button4.MouseClick -= messageBoxHello();
            }
        }

        private MouseEventHandler messageBoxHello()
        {
            return (o, args) => MessageBoxHello();
        }
    }
}