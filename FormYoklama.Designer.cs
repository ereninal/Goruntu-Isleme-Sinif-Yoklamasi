namespace WindowsFormsApp56
{
    partial class FormYoklama
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYoklama = new System.Windows.Forms.Button();
            this.lblGenel = new System.Windows.Forms.Label();
            this.dgYoklama = new System.Windows.Forms.DataGridView();
            this.sevkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgYoklama)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(483, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnYoklama
            // 
            this.btnYoklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoklama.Location = new System.Drawing.Point(387, 308);
            this.btnYoklama.Name = "btnYoklama";
            this.btnYoklama.Size = new System.Drawing.Size(90, 29);
            this.btnYoklama.TabIndex = 3;
            this.btnYoklama.Text = "Kaydet";
            this.btnYoklama.UseVisualStyleBackColor = true;
            this.btnYoklama.Click += new System.EventHandler(this.btnYoklama_Click);
            // 
            // lblGenel
            // 
            this.lblGenel.AutoSize = true;
            this.lblGenel.Location = new System.Drawing.Point(159, 313);
            this.lblGenel.Name = "lblGenel";
            this.lblGenel.Size = new System.Drawing.Size(16, 13);
            this.lblGenel.TabIndex = 4;
            this.lblGenel.Text = "...";
            // 
            // dgYoklama
            // 
            this.dgYoklama.AllowUserToAddRows = false;
            this.dgYoklama.AllowUserToDeleteRows = false;
            this.dgYoklama.AllowUserToResizeColumns = false;
            this.dgYoklama.AllowUserToResizeRows = false;
            this.dgYoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYoklama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sevkid,
            this.poliklinik,
            this.sira,
            this.Cinsiyet});
            this.dgYoklama.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgYoklama.Location = new System.Drawing.Point(12, 8);
            this.dgYoklama.Name = "dgYoklama";
            this.dgYoklama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgYoklama.Size = new System.Drawing.Size(465, 292);
            this.dgYoklama.TabIndex = 19;
            // 
            // sevkid
            // 
            this.sevkid.HeaderText = "Öğrenci NO";
            this.sevkid.Name = "sevkid";
            // 
            // poliklinik
            // 
            this.poliklinik.HeaderText = "Ad";
            this.poliklinik.Name = "poliklinik";
            this.poliklinik.Width = 120;
            // 
            // sira
            // 
            this.sira.HeaderText = "Soyad";
            this.sira.Name = "sira";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            // 
            // FormYoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 415);
            this.Controls.Add(this.dgYoklama);
            this.Controls.Add(this.lblGenel);
            this.Controls.Add(this.btnYoklama);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormYoklama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYoklama";
            this.Load += new System.EventHandler(this.FormYoklama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgYoklama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYoklama;
        private System.Windows.Forms.Label lblGenel;
        public System.Windows.Forms.DataGridView dgYoklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
    }
}