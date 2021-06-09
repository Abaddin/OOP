using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для PartyEditWindow.xaml
    /// </summary>
    public partial class PartyEditWindow : Window
    {
        Circle thePartyToys;
        public static List<Circle> AllCircles = new List<Circle>();
        public PartyEditWindow(Circle partyToys)
        {
            InitializeComponent();
            thePartyToys = partyToys;
            if (partyToys.Name != null)
            {
                listBox1.Items.Add(partyToys);
            }
            foreach (Circle i in AllCircles)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Circle circle = new Circle();
            ToyEditWindow toyEdit = new ToyEditWindow(circle);
            toyEdit.ShowDialog();
            AllCircles.Add(circle);
            listBox1.Items.Add(circle);
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                button4.IsEnabled = true;
            }
            else
            {
                button4.IsEnabled = false;

            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ToyEditWindow toyEdit = new ToyEditWindow(AllCircles[listBox1.SelectedIndex]);
            toyEdit.ShowDialog();
            RefreshData();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            thePartyToys.Name = textBox1.Text;
            thePartyToys.Section = (Head.Section)listBox1.SelectedItem;
            thePartyToys.Price = Convert.ToInt32(numericUpDown3.Text);
            thePartyToys.CountLessons = Convert.ToInt32(numericUpDown4.Text);
            thePartyToys.CountLessons = Convert.ToInt32(numericUpDown5.Text);
            Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            thePartyToys = new Circle();            
            Close();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //button2.IsEnabled = true;
        }

        public void RefreshData()
        {
            listBox1.Items.Clear();
            foreach (var i in AllCircles)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
