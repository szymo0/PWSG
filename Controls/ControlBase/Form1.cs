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

namespace ControlBase
{
    public partial class Form1 : Form
    {
        private const int BUTTON_WIDHT = 60;
        private const int BUTTON_HEIGHT = 30;
        private static int countAddButtonClick = 0;
        public Form1()
        {
            InitializeComponent();
            pnlAddedControls.BackColor = TransparencyKey;
        }

        private void BtnAddControls_Click(object sender, EventArgs e)
        {
            countAddButtonClick++;
            AddButtons(countAddButtonClick%2==0?pnlAddedControls:pnlTest2,CountControls());
            RefreshControlNumber();
        }

        private void AddButtons(Panel panel,int statIndex)
        {
            panel.Controls.Clear();

            var numberOfControls2Add = int.Parse(textBox1.Text);
            var controlsInRow = CountButtonsInRow(panel, numberOfControls2Add);


            for (int i = 0; i < numberOfControls2Add; i++)
            {
                var column = i % controlsInRow;
                var row = i / controlsInRow;

                Button button = new Button()
                {
                    Name = FormatButtonName(statIndex+i),
                    Text = (statIndex+i).ToString(),
                    Size = new Size(BUTTON_WIDHT, BUTTON_HEIGHT),
                    Location = GetAddedButtonLocation(row,column),
                    TabIndex = i,
                    //inny sposób ustawiania
                    //Left = column*BUTTON_WIDHT,
                    //Top = row*BUTTON_HEIGHT
                };
                Debug.WriteLine($"Add button {button.Name} on location {button.Location.X}:{button.Location.Y} in {panel.Name}");
                panel.Controls.Add(button);
                panel.BringToFront();
                panel.Visible = true;
            }
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

        private void BtnFind_Click(object sender, EventArgs e)
        {
            var buttonNumber=int.Parse(txtFind.Text);

            if (!pnlAddedControls.HasChildren)
            {
                MessageBox.Show("Brak dodanych przycisków");
                return;
            }

            var control=pnlAddedControls.Controls.Find(FormatButtonName(buttonNumber),false).FirstOrDefault();
            if (control == null)
            {
                MessageBox.Show("Nieznaleziono przycisku");
                return;
            }

            control.BackColor=Color.Aqua;
            control.Focus();

        }

        private string FormatButtonName(int i)
        {
            return "btn" + i;
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            if(panel==null || !panel.HasChildren) return;

            var controlsInRow = CountButtonsInRow(panel, panel.Controls.Count);

            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var column = i % controlsInRow;
                var row = i / controlsInRow;

                panel.Controls[i].Location = GetAddedButtonLocation(row, column);
            }

        }

        private int CountButtonsInRow(Panel panel, int controlsCount)
        {
            var width = panel.Width;
            return width / BUTTON_WIDHT;
        }

        private Point GetAddedButtonLocation(int row, int column)
        {
            return new Point(column * BUTTON_WIDHT, row * BUTTON_HEIGHT);
        }
    }
}
