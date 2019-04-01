using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollingControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                panel1.Controls.Add(new Button
                {
                    Name = "btn"+i,
                    Location = new Point(0,i*30),
                    Text=i.ToString()
                });
            }
        }
    }
}
