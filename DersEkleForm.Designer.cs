namespace WindowsFormsApp56
{
    partial class DersEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxders = new System.Windows.Forms.TextBox();
            this.richTextBoxacıklama = new System.Windows.Forms.RichTextBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acıklama";
            // 
            // textBoxders
            // 
            this.textBoxders.Location = new System.Drawing.Point(115, 29);
            this.textBoxders.Name = "textBoxders";
            this.textBoxders.Size = new System.Drawing.Size(100, 20);
            this.textBoxders.TabIndex = 2;
            // 
            // richTextBoxacıklama
            // 
            this.richTextBoxacıklama.Location = new System.Drawing.Point(105, 83);
            this.richTextBoxacıklama.Name = "richTextBoxacıklama";
            this.richTextBoxacıklama.Size = new System.Drawing.Size(387, 96);
            this.richTextBoxacıklama.TabIndex = 3;
            this.richTextBoxacıklama.Text = "";
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(417, 185);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(75, 23);
            this.buttonekle.TabIndex = 4;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // DersEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 233);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.richTextBoxacıklama);
            this.Controls.Add(this.textBoxders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DersEkleForm";
            this.Text = "DERS EKLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxders;
        private System.Windows.Forms.RichTextBox richTextBoxacıklama;
        private System.Windows.Forms.Button buttonekle;
    }
}