namespace OtelRezervasyon_DadasTurizm
{
    partial class FormUserInformation
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.grpReservationUserInf = new System.Windows.Forms.GroupBox();
            this.grpNewAcc = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.TextBox();
            this.mtxtPersonID = new System.Windows.Forms.TextBox();
            this.grpGuestsAdd = new System.Windows.Forms.GroupBox();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.grpAddGuestInfo = new System.Windows.Forms.GroupBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestSurname = new System.Windows.Forms.TextBox();
            this.txtGuestPersonID = new System.Windows.Forms.TextBox();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.btnAddGuests = new System.Windows.Forms.Button();
            this.lblRoomInformation = new System.Windows.Forms.Label();
            this.grpReservationUserInf.SuspendLayout();
            this.grpNewAcc.SuspendLayout();
            this.grpGuestsAdd.SuspendLayout();
            this.grpAddGuestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(112, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon Numarası";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "E-Mail";
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(188, 248);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(110, 44);
            this.btnCreateBook.TabIndex = 3;
            this.btnCreateBook.Text = "Next";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // grpReservationUserInf
            // 
            this.grpReservationUserInf.Controls.Add(this.grpNewAcc);
            this.grpReservationUserInf.Controls.Add(this.btnCreateBook);
            this.grpReservationUserInf.Location = new System.Drawing.Point(27, 29);
            this.grpReservationUserInf.Name = "grpReservationUserInf";
            this.grpReservationUserInf.Size = new System.Drawing.Size(315, 431);
            this.grpReservationUserInf.TabIndex = 4;
            this.grpReservationUserInf.TabStop = false;
            this.grpReservationUserInf.Text = "Step1";
            // 
            // grpNewAcc
            // 
            this.grpNewAcc.Controls.Add(this.btnSearch);
            this.grpNewAcc.Controls.Add(this.mtxtPhone);
            this.grpNewAcc.Controls.Add(this.mtxtPersonID);
            this.grpNewAcc.Controls.Add(this.txtFirstName);
            this.grpNewAcc.Controls.Add(this.label1);
            this.grpNewAcc.Controls.Add(this.label3);
            this.grpNewAcc.Controls.Add(this.label4);
            this.grpNewAcc.Controls.Add(this.label2);
            this.grpNewAcc.Controls.Add(this.label5);
            this.grpNewAcc.Controls.Add(this.txtEmail);
            this.grpNewAcc.Controls.Add(this.txtLastName);
            this.grpNewAcc.Location = new System.Drawing.Point(6, 79);
            this.grpNewAcc.Name = "grpNewAcc";
            this.grpNewAcc.Size = new System.Drawing.Size(292, 146);
            this.grpNewAcc.TabIndex = 6;
            this.grpNewAcc.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(231, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 30);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(112, 93);
            this.mtxtPhone.MaxLength = 10;
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(100, 20);
            this.mtxtPhone.TabIndex = 4;
            this.mtxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPersonID_KeyPress_1);
            // 
            // mtxtPersonID
            // 
            this.mtxtPersonID.Location = new System.Drawing.Point(112, 12);
            this.mtxtPersonID.MaxLength = 11;
            this.mtxtPersonID.Name = "mtxtPersonID";
            this.mtxtPersonID.Size = new System.Drawing.Size(100, 20);
            this.mtxtPersonID.TabIndex = 3;
            this.mtxtPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPersonID_KeyPress_1);
            // 
            // grpGuestsAdd
            // 
            this.grpGuestsAdd.Controls.Add(this.btnDeleteGuest);
            this.grpGuestsAdd.Controls.Add(this.lstGuests);
            this.grpGuestsAdd.Controls.Add(this.grpAddGuestInfo);
            this.grpGuestsAdd.Controls.Add(this.cmbRooms);
            this.grpGuestsAdd.Controls.Add(this.btnAddGuests);
            this.grpGuestsAdd.Controls.Add(this.lblRoomInformation);
            this.grpGuestsAdd.Location = new System.Drawing.Point(359, 29);
            this.grpGuestsAdd.Name = "grpGuestsAdd";
            this.grpGuestsAdd.Size = new System.Drawing.Size(654, 431);
            this.grpGuestsAdd.TabIndex = 5;
            this.grpGuestsAdd.TabStop = false;
            this.grpGuestsAdd.Text = "Step2";
            this.grpGuestsAdd.Visible = false;
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(186, 124);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(89, 25);
            this.btnDeleteGuest.TabIndex = 26;
            this.btnDeleteGuest.Text = "Delete Guests";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // lstGuests
            // 
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.Location = new System.Drawing.Point(12, 124);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(168, 134);
            this.lstGuests.TabIndex = 25;
            // 
            // grpAddGuestInfo
            // 
            this.grpAddGuestInfo.Controls.Add(this.lblGuestName);
            this.grpAddGuestInfo.Controls.Add(this.label7);
            this.grpAddGuestInfo.Controls.Add(this.label8);
            this.grpAddGuestInfo.Controls.Add(this.txtGuestName);
            this.grpAddGuestInfo.Controls.Add(this.txtGuestSurname);
            this.grpAddGuestInfo.Controls.Add(this.txtGuestPersonID);
            this.grpAddGuestInfo.Location = new System.Drawing.Point(11, 52);
            this.grpAddGuestInfo.Name = "grpAddGuestInfo";
            this.grpAddGuestInfo.Size = new System.Drawing.Size(456, 66);
            this.grpAddGuestInfo.TabIndex = 7;
            this.grpAddGuestInfo.TabStop = false;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(157, 27);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(66, 13);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Soyisim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "TC";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(228, 23);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(78, 20);
            this.txtGuestName.TabIndex = 1;
            // 
            // txtGuestSurname
            // 
            this.txtGuestSurname.Location = new System.Drawing.Point(369, 23);
            this.txtGuestSurname.Name = "txtGuestSurname";
            this.txtGuestSurname.Size = new System.Drawing.Size(78, 20);
            this.txtGuestSurname.TabIndex = 1;
            // 
            // txtGuestPersonID
            // 
            this.txtGuestPersonID.Location = new System.Drawing.Point(58, 27);
            this.txtGuestPersonID.MaxLength = 11;
            this.txtGuestPersonID.Name = "txtGuestPersonID";
            this.txtGuestPersonID.Size = new System.Drawing.Size(78, 20);
            this.txtGuestPersonID.TabIndex = 1;
            this.txtGuestPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPersonID_KeyPress_1);
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(11, 25);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(121, 21);
            this.cmbRooms.TabIndex = 24;
            this.cmbRooms.SelectedIndexChanged += new System.EventHandler(this.cmbRooms_SelectedIndexChanged);
            // 
            // btnAddGuests
            // 
            this.btnAddGuests.Location = new System.Drawing.Point(473, 74);
            this.btnAddGuests.Name = "btnAddGuests";
            this.btnAddGuests.Size = new System.Drawing.Size(110, 22);
            this.btnAddGuests.TabIndex = 23;
            this.btnAddGuests.Text = "Add Guests";
            this.btnAddGuests.UseVisualStyleBackColor = true;
            this.btnAddGuests.Click += new System.EventHandler(this.btnAddGuests_Click);
            // 
            // lblRoomInformation
            // 
            this.lblRoomInformation.AutoSize = true;
            this.lblRoomInformation.Location = new System.Drawing.Point(138, 33);
            this.lblRoomInformation.Name = "lblRoomInformation";
            this.lblRoomInformation.Size = new System.Drawing.Size(242, 13);
            this.lblRoomInformation.TabIndex = 0;
            this.lblRoomInformation.Text = "101 numaralı odada kalcak müsteri bilgilerini giriniz";
            // 
            // FormUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 496);
            this.Controls.Add(this.grpGuestsAdd);
            this.Controls.Add(this.grpReservationUserInf);
            this.Name = "FormUserInformation";
            this.Text = "FormUserInformation";
            this.Load += new System.EventHandler(this.FormUserInformation_Load);
            this.grpReservationUserInf.ResumeLayout(false);
            this.grpNewAcc.ResumeLayout(false);
            this.grpNewAcc.PerformLayout();
            this.grpGuestsAdd.ResumeLayout(false);
            this.grpGuestsAdd.PerformLayout();
            this.grpAddGuestInfo.ResumeLayout(false);
            this.grpAddGuestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.GroupBox grpReservationUserInf;
        private System.Windows.Forms.GroupBox grpGuestsAdd;
        private System.Windows.Forms.Label lblRoomInformation;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Button btnAddGuests;
        private System.Windows.Forms.TextBox txtGuestPersonID;
        private System.Windows.Forms.TextBox txtGuestSurname;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.GroupBox grpAddGuestInfo;
        private System.Windows.Forms.GroupBox grpNewAcc;
        private System.Windows.Forms.TextBox mtxtPersonID;
        private System.Windows.Forms.TextBox mtxtPhone;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.Button btnSearch;
    }
}