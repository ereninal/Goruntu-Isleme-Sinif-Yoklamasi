namespace WindowsFormsApp56
{
    partial class OgrenciSilform
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
            this.buttonsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Numara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(221, 62);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(81, 25);
            this.buttonsil.TabIndex = 0;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silinmek istenen Öğrencinin Numarası";
            // 
            // textBox_Numara
            // 
            this.textBox_Numara.Enabled = false;
            this.textBox_Numara.Location = new System.Drawing.Point(202, 36);
            this.textBox_Numara.Name = "textBox_Numara";
            this.textBox_Numara.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numara.TabIndex = 2;
            // 
            // OgrenciSilform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(328, 113);
            this.Controls.Add(this.textBox_Numara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OgrenciSilform";
            this.Text = "ÖĞRENCİ SİLME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Numara;
    }
}