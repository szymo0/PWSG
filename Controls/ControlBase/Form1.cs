using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlBase
{
    public partial class Form1 : Form
    {
        private const int BUTTON_WIDHT = 60;
        private const int BUTTON_HEIGHT = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddControls_Click(object sender, EventArgs e)
        {
            var width = pnlAddedControls.Width;

            var numberOfControls2Add = int.Parse(textBox1.Text);

            var controlsInRow = width / BUTTON_WIDHT;


            for (int i = 0; i < numberOfControls2Add; i++)
            {
                var column = i % controlsInRow;
                var row = i / controlsInRow;
                Button button = new Button()
                {
                    Name = "btn" + i,
                    Text = i.ToString(),
                    Size = new Size(BUTTON_WIDHT,BUTTON_HEIGHT),
                    Left = column*BUTTON_WIDHT,
                    Top = row*BUTTON_HEIGHT
                };
                pnlAddedControls.Controls.Add(button);
            }

        }

        private void BtnCountControls_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"kontrolek na formie: {this.Controls.Count}");
        }
    }
}
