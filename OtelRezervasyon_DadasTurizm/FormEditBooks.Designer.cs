namespace OtelRezervasyon_DadasTurizm
{
    partial class FormEditBooks
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvEditBooks = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtNightStay = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpGuests = new System.Windows.Forms.GroupBox();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.btnHardDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBooks)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.grpGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(752, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Soft Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(753, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvEditBooks
            // 
            this.dgvEditBooks.AllowUserToOrderColumns = true;
            this.dgvEditBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditBooks.Location = new System.Drawing.Point(13, 11);
            this.dgvEditBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEditBooks.Name = "dgvEditBooks";
            this.dgvEditBooks.RowTemplate.Height = 24;
            this.dgvEditBooks.Size = new System.Drawing.Size(842, 195);
            this.dgvEditBooks.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(4, 33);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(105, 17);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckIn.Location = new System.Drawing.Point(4, 73);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(97, 17);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "Check-In Date";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckOut.Location = new System.Drawing.Point(324, 73);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(109, 17);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check-Out Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(324, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Night Stay";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerName.Location = new System.Drawing.Point(115, 31);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(177, 23);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtNightStay
            // 
            this.txtNightStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNightStay.Location = new System.Drawing.Point(115, 106);
            this.txtNightStay.Margin = new System.Windows.Forms.Padding(2);
            this.txtNightStay.Name = "txtNightStay";
            this.txtNightStay.Size = new System.Drawing.Size(76, 23);
            this.txtNightStay.TabIndex = 5;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalCost.Location = new System.Drawing.Point(434, 110);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(76, 23);
            this.txtTotalCost.TabIndex = 5;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckIn.Location = new System.Drawing.Point(115, 69);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(177, 23);
            this.dtpCheckIn.TabIndex = 6;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckOut.Location = new System.Drawing.Point(434, 69);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(177, 23);
            this.dtpCheckOut.TabIndex = 6;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.txtCustomerName);
            this.gbEdit.Controls.Add(this.dtpCheckOut);
            this.gbEdit.Controls.Add(this.btnSave);
            this.gbEdit.Controls.Add(this.lblCustomerName);
            this.gbEdit.Controls.Add(this.dtpCheckIn);
            this.gbEdit.Controls.Add(this.lblCheckIn);
            this.gbEdit.Controls.Add(this.txtTotalCost);
            this.gbEdit.Controls.Add(this.lblCheckOut);
            this.gbEdit.Controls.Add(this.txtNightStay);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.label5);
            this.gbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbEdit.Location = new System.Drawing.Point(13, 210);
            this.gbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.gbEdit.Size = new System.Drawing.Size(735, 155);
            this.gbEdit.TabIndex = 7;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Reservation İnformation";
            this.gbEdit.Enter += new System.EventHandler(this.gbEdit_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(628, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpGuests
            // 
            this.grpGuests.Controls.Add(this.btnEditGuest);
            this.grpGuests.Controls.Add(this.dgvGuests);
            this.grpGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGuests.Location = new System.Drawing.Point(13, 370);
            this.grpGuests.Margin = new System.Windows.Forms.Padding(2);
            this.grpGuests.Name = "grpGuests";
            this.grpGuests.Padding = new System.Windows.Forms.Padding(2);
            this.grpGuests.Size = new System.Drawing.Size(735, 235);
            this.grpGuests.TabIndex = 8;
            this.grpGuests.TabStop = false;
            this.grpGuests.Text = "Guests Information";
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditGuest.Location = new System.Drawing.Point(628, 21);
            this.btnEditGuest.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditGuest.Name = "btnEditGuest";
            this.btnEditGuest.Size = new System.Drawing.Size(101, 63);
            this.btnEditGuest.TabIndex = 1;
            this.btnEditGuest.Text = "Edit Guests";
            this.btnEditGuest.UseVisualStyleBackColor = true;
            this.btnEditGuest.Click += new System.EventHandler(this.btnEditGuest_Click);
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToOrderColumns = true;
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(8, 21);
            this.dgvGuests.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowTemplate.Height = 24;
            this.dgvGuests.Size = new System.Drawing.Size(603, 206);
            this.dgvGuests.TabIndex = 0;
            // 
            // btnHardDelete
            // 
            this.btnHardDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHardDelete.Location = new System.Drawing.Point(753, 329);
            this.btnHardDelete.Name = "btnHardDelete";
            this.btnHardDelete.Size = new System.Drawing.Size(102, 49);
            this.btnHardDelete.TabIndex = 1;
            this.btnHardDelete.Text = "Hard Delete";
            this.btnHardDelete.UseVisualStyleBackColor = true;
            this.btnHardDelete.Click += new System.EventHandler(this.btnHardDelete_Click);
            // 
            // FormEditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 608);
            this.Controls.Add(this.grpGuests);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.dgvEditBooks);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHardDelete);
            this.Controls.Add(this.btnDelete);
            this.Name = "FormEditBooks";
            this.Text = "Edit Books";
            this.Load += new System.EventHandler(this.FormEditBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBooks)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.grpGuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvEditBooks;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtNightStay;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpGuests;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.Button btnHardDelete;
    }
}