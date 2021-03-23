using System.Windows.Forms;

namespace WinLinkLabel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public string TextBoxValue
        {
            get { return textBox1.Text;} 
            set { textBox1.Text = value;}
        } 
        
        public string TextBoxValue2
        {
            get { return textBox2.Text;} 
            set { textBox2.Text = value;}
        } 
    }
}