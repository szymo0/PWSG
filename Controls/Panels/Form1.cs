using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            //tabControl1.SelectedIndex = tabPage2.TabIndex;
            //tabControl1.SelectedTab = tabPage2;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Bottom;
        }
    }
}
