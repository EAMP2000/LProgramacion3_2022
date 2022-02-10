namespace ErickL3
{
    partial class arreglos
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
            this.DiasListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.NombresListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EdadesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DiasListBox
            // 
            this.DiasListBox.FormattingEnabled = true;
            this.DiasListBox.Location = new System.Drawing.Point(146, 90);
            this.DiasListBox.Name = "DiasListBox";
            this.DiasListBox.Size = new System.Drawing.Size(120, 134);
            this.DiasListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(337, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(188, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(348, 63);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(49, 13);
            this.Nombres.TabIndex = 4;
            this.Nombres.Text = "Nombres";
            // 
            // NombresListBox
            // 
            this.NombresListBox.FormattingEnabled = true;
            this.NombresListBox.Location = new System.Drawing.Point(317, 90);
            this.NombresListBox.Name = "NombresListBox";
            this.NombresListBox.Size = new System.Drawing.Size(120, 134);
            this.NombresListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edades";
            // 
            // EdadesListBox
            // 
            this.EdadesListBox.FormattingEnabled = true;
            this.EdadesListBox.Location = new System.Drawing.Point(482, 90);
            this.EdadesListBox.Name = "EdadesListBox";
            this.EdadesListBox.Size = new System.Drawing.Size(120, 134);
            this.EdadesListBox.TabIndex = 5;
            // 
            // arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EdadesListBox);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.NombresListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DiasListBox);
            this.Name = "arreglos";
            this.Text = "arreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DiasListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.ListBox NombresListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox EdadesListBox;
    }
}