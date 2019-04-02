using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.Font = (Font)fontDialog1.Font.Clone();
            richTextBox1.SelectionFont = (Font)fontDialog1.Font.Clone();
        }
    }
}
