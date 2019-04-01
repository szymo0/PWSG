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
            pnlAddedControls.Controls.Clear();

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
                    Location = new Point(column * BUTTON_WIDHT, row * BUTTON_HEIGHT)
                    //inny sposób ustawiania
                    //Left = column*BUTTON_WIDHT,
                    //Top = row*BUTTON_HEIGHT
                };
                pnlAddedControls.Controls.Add(button);
            }
            RefreshControlNumber();
        }

        private void BtnCountControls_Click(object sender, EventArgs e)
        {
            RefreshControlNumber(true);
        }

        private void RefreshControlNumber(bool showMessageBox=false)
        {
            var message = $"kontrolek na formie: {CountControls()}";
            if(showMessageBox)
                MessageBox.Show(message);
            this.Text = message;
        }

        private int CountControls()
        {
            int count = 0;
            if (!HasChildren) return count;
            foreach (Control control in Controls)
            {
                count += CountChildsControls(control)+1;
            }

            return count;
        }

        private int CountChildsControls(Control control)
        {
            if (control == null) return 0;
            if (!control.HasChildren) return 0;

            int count = 0; 
            foreach (Control childControl in control.Controls)
            {
                count += CountChildsControls(childControl) + 1;
            }

            return count;
        }
    }
}
