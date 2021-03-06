﻿using System;
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
    /// Логика взаимодействия для ToyShopWindow.xaml
    /// </summary>
    public partial class ToyShopWindow : Window
    {
        ToyShop theShop;
        public ToyShopWindow(ToyShop toyShop)
        {
            InitializeComponent();
            theShop = toyShop;
            if (theShop != null)
            {
                MagInfo.Text = theShop.ToShortString();
                foreach (Circle party in theShop.supplies)
                {
                    listBox1.Items.Add(party);
                }
            }
            RefreshData();
        }

        private void RefreshData()
        {
            MagInfo.Text = theShop.ToShortString();
            listBox1.Items.Clear();
            foreach (Circle party in theShop.supplies)
            {
                listBox1.Items.Add(party);
            }
            if (listBox1.Items.Count != 0)
            {
                button2.IsEnabled = true;
                button3.IsEnabled = true;
            }
            else
            {
                button2.IsEnabled = false;
                button3.IsEnabled = false;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Circle party = new Circle();
            PartyEditWindow partyEdit = new PartyEditWindow(party);
            partyEdit.ShowDialog();

            RefreshData();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PartyEditWindow partyEdit = new PartyEditWindow(theShop.supplies[listBox1.SelectedIndex]);
            partyEdit.ShowDialog();
            RefreshData();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            theShop.supplies.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            RefreshData();
        }
    }
}
