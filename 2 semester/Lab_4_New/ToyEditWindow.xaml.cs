using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ToyEditWindow.xaml
    /// </summary>
    public partial class ToyEditWindow : Window
    {
        Circle theCircle;
        public ToyEditWindow(Circle circle)
        {
            InitializeComponent();
            theCircle = circle;
            if (theCircle.Name != null)
            {
                textBox1.Text = theCircle.Name;
                comboBox1.SelectedItem = theCircle.Section;
                numeric1.Text = Convert.ToString(theCircle.Price);
                numeric2.Text = Convert.ToString(theCircle.CountLessons);
                numeric3.Text = Convert.ToString(theCircle.CountStudents);
            }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                theCircle.Name = textBox1.Text;
                theCircle.Section = (Head.Section)comboBox1.SelectedItem;
                theCircle.Price = Convert.ToInt32(numeric1.Text);
                theCircle.CountLessons = Convert.ToInt32(numeric2.Text);
                theCircle.CountStudents = Convert.ToInt32(numeric3.Text);
                //DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Не можна створити гурток без назви");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add(Head.Section.Малювання);
            comboBox1.Items.Add(Head.Section.Танцювальний);
            comboBox1.Items.Add(Head.Section.Моделювання);
            comboBox1.Items.Add(Head.Section.Мяка_іграшка);
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            theCircle = new Circle();
            //DialogResult = DialogResult.No;
            Close();
        }
    }
}
