using System;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class Form1 : Form
    {
        private int openDocuments;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    try
                    {
                        Form newChіld = new Form();
                        newChіld.Show();
                        newChіld.Text = newChіld.Text + "" +
                                        ++openDocuments;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                case "Cascade":
                    try
                    {
                        this.LayoutMdi(MdiLayout.Cascade);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                case "Tіtle":
                    try
                    {
                        this.LayoutMdi(MdiLayout.TileHorizontal);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
            }
        }
    }
}