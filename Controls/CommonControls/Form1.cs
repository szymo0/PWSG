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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("CheckedChange");
            Debug.WriteLine($"CheckState {checkBox1.CheckState}");
            Debug.WriteLine($"Checked {checkBox1.Checked}");

        }

        private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("CheckStateChanged");
            Debug.WriteLine($"CheckState {checkBox1.CheckState}");
            Debug.WriteLine($"Checked {checkBox1.Checked}");
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = ((RadioButton)sender).Checked;
        }
    }
}
