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
            this.splitContainer1.SplitterDistance = 85;

            //for (int i = 0; i < 100; i++)
            //{
            //    this.groupBox1.Controls.Add(new Button
            //    {
            //        Name = "btn"+i,
            //        Size = new Size(30,30),
            //        Text = i.ToString()
            //    });
            //}

            Timer timer=new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private int direction = 1;
        private void Timer_Tick(object sender, EventArgs e)
        {
            var width = this.splitContainer1.Width;
            if(this.splitContainer1.SplitterDistance+2>=this.splitContainer1.Width-80)
                direction = direction * -1;
            if (this.splitContainer1.SplitterDistance - 2 <= 80)
                direction = direction * -1;

            this.splitContainer1.SplitterDistance = this.splitContainer1.SplitterDistance +(direction)* 2;
        }
    }
}
