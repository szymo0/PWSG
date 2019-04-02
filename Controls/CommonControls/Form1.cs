using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("TextBox1_KeyDown");
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("TextBox1_KeyPress");
            if (e.KeyChar == 'm') e.Handled = true;

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("TextBox1_KeyUp");
        }

        private void TextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Debug.WriteLine("TextBox1_PreviewKeyDown");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }
    }
}
