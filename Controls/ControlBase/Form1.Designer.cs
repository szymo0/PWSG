namespace ControlBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddControls = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddedControls = new System.Windows.Forms.Panel();
            this.btnCountControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddControls
            // 
            this.btnAddControls.Location = new System.Drawing.Point(308, 12);
            this.btnAddControls.Name = "btnAddControls";
            this.btnAddControls.Size = new System.Drawing.Size(116, 23);
            this.btnAddControls.TabIndex = 0;
            this.btnAddControls.Text = "Dodaj kontrolki";
            this.btnAddControls.UseVisualStyleBackColor = true;
            this.btnAddControls.Click += new System.EventHandler(this.BtnAddControls_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj liczbę od 1-10";
            // 
            // pnlAddedControls
            // 
            this.pnlAddedControls.Location = new System.Drawing.Point(12, 50);
            this.pnlAddedControls.Name = "pnlAddedControls";
            this.pnlAddedControls.Size = new System.Drawing.Size(412, 220);
            this.pnlAddedControls.TabIndex = 3;
            // 
            // btnCountControls
            // 
            this.btnCountControls.Location = new System.Drawing.Point(297, 285);
            this.btnCountControls.Name = "btnCountControls";
            this.btnCountControls.Size = new System.Drawing.Size(127, 26);
            this.btnCountControls.TabIndex = 4;
            this.btnCountControls.Text = "Zlicz kontrolki";
            this.btnCountControls.UseVisualStyleBackColor = true;
            this.btnCountControls.Click += new System.EventHandler(this.BtnCountControls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 330);
            this.Controls.Add(this.btnCountControls);
            this.Controls.Add(this.pnlAddedControls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddControls;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddedControls;
        private System.Windows.Forms.Button btnCountControls;
    }
}

