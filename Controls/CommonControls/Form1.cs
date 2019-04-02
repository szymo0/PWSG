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
            checkedListBox1.CheckOnClick = true;
      
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = "Wybrałeś " + ((string)checkedListBox1.SelectedItem);
        }

        private void CheckedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder("Do załatwienia pozostało:");
            stringBuilder.AppendLine();
            foreach(var item in checkedListBox1.Items)
            {
                if (checkedListBox1.CheckedItems.Contains(item)) continue;
                stringBuilder.AppendLine(" - "+ item.ToString());
            }

            textBox1.Text = stringBuilder.ToString();
        }
    }
}
