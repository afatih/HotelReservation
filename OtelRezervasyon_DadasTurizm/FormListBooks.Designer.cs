namespace OtelRezervasyon_DadasTurizm
{
    partial class FormListBooks
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
            this.dgvListBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListBooks
            // 
            this.dgvListBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvListBooks.Name = "dgvListBooks";
            this.dgvListBooks.RowTemplate.Height = 24;
            this.dgvListBooks.Size = new System.Drawing.Size(1036, 553);
            this.dgvListBooks.TabIndex = 0;
            // 
            // FormListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 553);
            this.Controls.Add(this.dgvListBooks);
            this.Name = "FormListBooks";
            this.Text = "List Books";
            this.Load += new System.EventHandler(this.FormListBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBooks;
    }
}