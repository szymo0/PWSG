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

            for (int i = 0; i < 100; i++)
            {
                this.flowLayoutPanel1.Controls.Add(new Button
                {
                    Name = "btn"+i,
                    Size = new Size(30,30),
                    Text = i.ToString()
                });
            }

            this.flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
        }
    }
}
