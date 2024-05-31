namespace SCV_Jela
{
    partial class FormaMeniji
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
            this.dgvMeniji = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeniji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeniji
            // 
            this.dgvMeniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeniji.Location = new System.Drawing.Point(12, 12);
            this.dgvMeniji.Name = "dgvMeniji";
            this.dgvMeniji.RowTemplate.Height = 24;
            this.dgvMeniji.Size = new System.Drawing.Size(900, 577);
            this.dgvMeniji.TabIndex = 0;
            this.dgvMeniji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeniji_CellContentClick);
            // 
            // FormaMeniji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.dgvMeniji);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaMeniji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV Jela - Meniji";
            this.Load += new System.EventHandler(this.FormaMeniji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeniji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeniji;
    }
}