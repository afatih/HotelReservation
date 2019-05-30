namespace OtelRezervasyon_DadasTurizm
{
    partial class FormListCustomers
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
            this.dgwEditCustomers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sada = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEditCustomers)).BeginInit();
            this.grpbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEditCustomers
            // 
            this.dgwEditCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEditCustomers.Location = new System.Drawing.Point(15, 45);
            this.dgwEditCustomers.Name = "dgwEditCustomers";
            this.dgwEditCustomers.Size = new System.Drawing.Size(773, 324);
            this.dgwEditCustomers.TabIndex = 0;
            this.dgwEditCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEditCustomers_CellContentClick);
            this.dgwEditCustomers.SelectionChanged += new System.EventHandler(this.dgwEditCustomers_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(190, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Giriniz";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(371, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpbxUpdate
            // 
            this.grpbxUpdate.Controls.Add(this.txtPersonID);
            this.grpbxUpdate.Controls.Add(this.txtEmail);
            this.grpbxUpdate.Controls.Add(this.txtPhoneNum);
            this.grpbxUpdate.Controls.Add(this.btnUpdateSave);
            this.grpbxUpdate.Controls.Add(this.l);
            this.grpbxUpdate.Controls.Add(this.label4);
            this.grpbxUpdate.Controls.Add(this.label3);
            this.grpbxUpdate.Controls.Add(this.txtLastName);
            this.grpbxUpdate.Controls.Add(this.txtFirstName);
            this.grpbxUpdate.Controls.Add(this.label2);
            this.grpbxUpdate.Controls.Add(this.sada);
            this.grpbxUpdate.Location = new System.Drawing.Point(15, 394);
            this.grpbxUpdate.Name = "grpbxUpdate";
            this.grpbxUpdate.Size = new System.Drawing.Size(773, 231);
            this.grpbxUpdate.TabIndex = 6;
            this.grpbxUpdate.TabStop = false;
            this.grpbxUpdate.Text = " ";
            this.grpbxUpdate.Visible = false;
            this.grpbxUpdate.Enter += new System.EventHandler(this.grpbxUpdate_Enter);
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(90, 91);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonID.TabIndex = 13;
            this.txtPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(331, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(331, 29);
            this.txtPhoneNum.MaxLength = 10;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 11;
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(356, 91);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSave.TabIndex = 10;
            this.btnUpdateSave.Text = "Kaydet";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(229, 64);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(36, 13);
            this.l.TabIndex = 7;
            this.l.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TcNo";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // sada
            // 
            this.sada.AutoSize = true;
            this.sada.Location = new System.Drawing.Point(32, 32);
            this.sada.Name = "sada";
            this.sada.Size = new System.Drawing.Size(22, 13);
            this.sada.TabIndex = 0;
            this.sada.Text = "Adı";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(280, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // FormListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.grpbxUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgwEditCustomers);
            this.Name = "FormListCustomers";
            this.Text = "FormListCustomers";
            this.Load += new System.EventHandler(this.FormListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEditCustomers)).EndInit();
            this.grpbxUpdate.ResumeLayout(false);
            this.grpbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEditCustomers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpbxUpdate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtPersonID;
    }
}