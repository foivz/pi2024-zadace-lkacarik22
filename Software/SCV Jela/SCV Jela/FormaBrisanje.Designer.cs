namespace SCV_Jela
{
    partial class FormaBrisanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBrisanje));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_brisanje = new System.Windows.Forms.TextBox();
            this.gumb_brisanje = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ID menija koji želite obrisati:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_brisanje
            // 
            this.textBox_brisanje.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_brisanje.Location = new System.Drawing.Point(426, 144);
            this.textBox_brisanje.Name = "textBox_brisanje";
            this.textBox_brisanje.Size = new System.Drawing.Size(56, 32);
            this.textBox_brisanje.TabIndex = 5;
            this.textBox_brisanje.TextChanged += new System.EventHandler(this.textBox_brisanje_TextChanged);
            // 
            // gumb_brisanje
            // 
            this.gumb_brisanje.BackColor = System.Drawing.Color.CadetBlue;
            this.gumb_brisanje.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumb_brisanje.Location = new System.Drawing.Point(372, 263);
            this.gumb_brisanje.Name = "gumb_brisanje";
            this.gumb_brisanje.Size = new System.Drawing.Size(179, 41);
            this.gumb_brisanje.TabIndex = 7;
            this.gumb_brisanje.Text = "Obriši meni";
            this.gumb_brisanje.UseVisualStyleBackColor = false;
            this.gumb_brisanje.Click += new System.EventHandler(this.gumb_brisanje_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 67);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormaBrisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gumb_brisanje);
            this.Controls.Add(this.textBox_brisanje);
            this.Controls.Add(this.label1);
            this.Name = "FormaBrisanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV Jela -Brisanje menija";
            this.Load += new System.EventHandler(this.FormaBrisanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_brisanje;
        private System.Windows.Forms.Button gumb_brisanje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}