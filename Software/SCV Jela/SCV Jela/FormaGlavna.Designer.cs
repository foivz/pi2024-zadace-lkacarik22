namespace SCV_Jela
{
    partial class FormaGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGlavna));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_prijava = new System.Windows.Forms.TextBox();
            this.textBox_lozinka = new System.Windows.Forms.TextBox();
            this.gumb_prijava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli u sustav SCV Jela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisničko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lozinka";
            // 
            // textBox_prijava
            // 
            this.textBox_prijava.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prijava.Location = new System.Drawing.Point(362, 199);
            this.textBox_prijava.Name = "textBox_prijava";
            this.textBox_prijava.Size = new System.Drawing.Size(150, 32);
            this.textBox_prijava.TabIndex = 4;
            this.textBox_prijava.TextChanged += new System.EventHandler(this.textBox_prijava_TextChanged);
            // 
            // textBox_lozinka
            // 
            this.textBox_lozinka.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lozinka.Location = new System.Drawing.Point(362, 244);
            this.textBox_lozinka.Name = "textBox_lozinka";
            this.textBox_lozinka.Size = new System.Drawing.Size(150, 32);
            this.textBox_lozinka.TabIndex = 5;
            this.textBox_lozinka.TextChanged += new System.EventHandler(this.textBox_lozinka_TextChanged);
            // 
            // gumb_prijava
            // 
            this.gumb_prijava.BackColor = System.Drawing.Color.CadetBlue;
            this.gumb_prijava.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumb_prijava.Location = new System.Drawing.Point(283, 316);
            this.gumb_prijava.Name = "gumb_prijava";
            this.gumb_prijava.Size = new System.Drawing.Size(134, 41);
            this.gumb_prijava.TabIndex = 6;
            this.gumb_prijava.Text = "Prijavi se";
            this.gumb_prijava.UseVisualStyleBackColor = false;
            this.gumb_prijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.gumb_prijava);
            this.Controls.Add(this.textBox_lozinka);
            this.Controls.Add(this.textBox_prijava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormaGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV Jela - Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_prijava;
        private System.Windows.Forms.TextBox textBox_lozinka;
        private System.Windows.Forms.Button gumb_prijava;
    }
}

