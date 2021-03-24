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
            spData.Text = Convert.ToString(DateTime.Today.ToLongDateString());
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    try
                    {
                        Form newChіld = new Form();
                        newChіld.IsMdiContainer = true;
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
                        LayoutMdi(MdiLayout.Cascade);
                        spWin.Text = "Windows is cascade";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                case "Tіtle":
                    try
                    {
                        LayoutMdi(MdiLayout.TileHorizontal);
                        spWin.Text = "Windows is horizontal";
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