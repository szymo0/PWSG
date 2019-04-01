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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTest2 = new System.Windows.Forms.Panel();
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
            this.pnlAddedControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddedControls.Location = new System.Drawing.Point(34, 74);
            this.pnlAddedControls.Name = "pnlAddedControls";
            this.pnlAddedControls.Size = new System.Drawing.Size(349, 172);
            this.pnlAddedControls.TabIndex = 3;
            this.pnlAddedControls.Resize += new System.EventHandler(this.Panel_Resize);
            // 
            // btnCountControls
            // 
            this.btnCountControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountControls.Location = new System.Drawing.Point(394, 285);
            this.btnCountControls.Name = "btnCountControls";
            this.btnCountControls.Size = new System.Drawing.Size(127, 26);
            this.btnCountControls.TabIndex = 4;
            this.btnCountControls.Text = "Zlicz kontrolki";
            this.btnCountControls.UseVisualStyleBackColor = true;
            this.btnCountControls.Click += new System.EventHandler(this.BtnCountControls_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(72, 288);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(56, 22);
            this.txtFind.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(134, 288);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Znajdź";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Znajdź";
            // 
            // pnlTest2
            // 
            this.pnlTest2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTest2.Location = new System.Drawing.Point(183, 39);
            this.pnlTest2.Name = "pnlTest2";
            this.pnlTest2.Size = new System.Drawing.Size(326, 190);
            this.pnlTest2.TabIndex = 8;
            this.pnlTest2.Resize += new System.EventHandler(this.Panel_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 330);
            this.Controls.Add(this.pnlTest2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
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
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTest2;
    }
}

