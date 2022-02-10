namespace ErickL3
{
    partial class FuncionesFecha
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProcesarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiaLetrasTextBox = new System.Windows.Forms.TextBox();
            this.MesLetrasTextBox = new System.Windows.Forms.TextBox();
            this.SumarDiasTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(313, 35);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 0;
            // 
            // ProcesarButton
            // 
            this.ProcesarButton.Location = new System.Drawing.Point(538, 35);
            this.ProcesarButton.Name = "ProcesarButton";
            this.ProcesarButton.Size = new System.Drawing.Size(75, 23);
            this.ProcesarButton.TabIndex = 1;
            this.ProcesarButton.Text = "Procesar";
            this.ProcesarButton.UseVisualStyleBackColor = true;
            this.ProcesarButton.Click += new System.EventHandler(this.ProcesarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dia";
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Location = new System.Drawing.Point(124, 78);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiaTextBox.TabIndex = 3;
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(124, 113);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(100, 20);
            this.MesTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes";
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Location = new System.Drawing.Point(124, 148);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnioTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // DiaLetrasTextBox
            // 
            this.DiaLetrasTextBox.Location = new System.Drawing.Point(313, 78);
            this.DiaLetrasTextBox.Name = "DiaLetrasTextBox";
            this.DiaLetrasTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiaLetrasTextBox.TabIndex = 8;
            // 
            // MesLetrasTextBox
            // 
            this.MesLetrasTextBox.Location = new System.Drawing.Point(313, 117);
            this.MesLetrasTextBox.Name = "MesLetrasTextBox";
            this.MesLetrasTextBox.Size = new System.Drawing.Size(100, 20);
            this.MesLetrasTextBox.TabIndex = 9;
            // 
            // SumarDiasTextBox
            // 
            this.SumarDiasTextBox.Location = new System.Drawing.Point(124, 185);
            this.SumarDiasTextBox.Name = "SumarDiasTextBox";
            this.SumarDiasTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumarDiasTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sumar dias";
            // 
            // FuncionesFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumarDiasTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MesLetrasTextBox);
            this.Controls.Add(this.DiaLetrasTextBox);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcesarButton);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "FuncionesFecha";
            this.Text = "FuncionesFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button ProcesarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiaLetrasTextBox;
        private System.Windows.Forms.TextBox MesLetrasTextBox;
        private System.Windows.Forms.TextBox SumarDiasTextBox;
        private System.Windows.Forms.Label label4;
    }
}