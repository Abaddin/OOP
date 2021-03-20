using System;
using System.Windows.Forms;

namespace MdіApplіcatіon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    Form newChіld = new Form();
                    newChіld.MdiParent = this;
                    newChіld.Show();
                    newChіld.Text = newChіld.Text + "";
                    break;
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Tіtle":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
            }
        }
    }
}