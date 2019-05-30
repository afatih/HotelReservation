namespace OtelRezervasyon_DadasTurizm
{
    partial class FormRezervasyonAnasayfa
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
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomDescription = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoomTypes = new System.Windows.Forms.ComboBox();
            this.pcbOdaResmi = new System.Windows.Forms.PictureBox();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPerson = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChild = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPersonNumber = new System.Windows.Forms.Label();
            this.lblRoomCapacities = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.flpReservations = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.flwPnl = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOdaResmi)).BeginInit();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChild)).BeginInit();
            this.grpReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(16, 48);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(265, 22);
            this.dtpCheckIn.TabIndex = 1;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Enabled = false;
            this.dtpCheckOut.Location = new System.Drawing.Point(17, 139);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(265, 22);
            this.dtpCheckOut.TabIndex = 1;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check-Out Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check-In Date";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(152, 423);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(131, 36);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddRoom.Location = new System.Drawing.Point(457, 268);
            this.buttonAddRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(136, 50);
            this.buttonAddRoom.TabIndex = 0;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(8, 39);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(0, 20);
            this.lblRoomType.TabIndex = 13;
            // 
            // lblRoomDescription
            // 
            this.lblRoomDescription.AutoSize = true;
            this.lblRoomDescription.Location = new System.Drawing.Point(8, 81);
            this.lblRoomDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomDescription.Name = "lblRoomDescription";
            this.lblRoomDescription.Size = new System.Drawing.Size(0, 17);
            this.lblRoomDescription.TabIndex = 13;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.Location = new System.Drawing.Point(8, 177);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(0, 24);
            this.lblRoomPrice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Room Type";
            // 
            // cmbRoomTypes
            // 
            this.cmbRoomTypes.Enabled = false;
            this.cmbRoomTypes.FormattingEnabled = true;
            this.cmbRoomTypes.Location = new System.Drawing.Point(17, 304);
            this.cmbRoomTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoomTypes.Name = "cmbRoomTypes";
            this.cmbRoomTypes.Size = new System.Drawing.Size(160, 24);
            this.cmbRoomTypes.TabIndex = 12;
            this.cmbRoomTypes.SelectedIndexChanged += new System.EventHandler(this.cmbRoomTypes_SelectedIndexChanged);
            // 
            // pcbOdaResmi
            // 
            this.pcbOdaResmi.Location = new System.Drawing.Point(305, 28);
            this.pcbOdaResmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbOdaResmi.Name = "pcbOdaResmi";
            this.pcbOdaResmi.Size = new System.Drawing.Size(291, 222);
            this.pcbOdaResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOdaResmi.TabIndex = 14;
            this.pcbOdaResmi.TabStop = false;
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.lblRoomType);
            this.grpInformation.Controls.Add(this.pcbOdaResmi);
            this.grpInformation.Controls.Add(this.lblRoomDescription);
            this.grpInformation.Controls.Add(this.buttonAddRoom);
            this.grpInformation.Controls.Add(this.lblRoomPrice);
            this.grpInformation.Location = new System.Drawing.Point(323, 276);
            this.grpInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInformation.Size = new System.Drawing.Size(631, 330);
            this.grpInformation.TabIndex = 15;
            this.grpInformation.TabStop = false;
            this.grpInformation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Person Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Child Number";
            // 
            // numericUpDownPerson
            // 
            this.numericUpDownPerson.Location = new System.Drawing.Point(43, 220);
            this.numericUpDownPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPerson.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPerson.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPerson.Name = "numericUpDownPerson";
            this.numericUpDownPerson.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownPerson.TabIndex = 16;
            this.numericUpDownPerson.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPerson.ValueChanged += new System.EventHandler(this.numericUpDownPerson_ValueChanged);
            // 
            // numericUpDownChild
            // 
            this.numericUpDownChild.Location = new System.Drawing.Point(191, 220);
            this.numericUpDownChild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownChild.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownChild.Name = "numericUpDownChild";
            this.numericUpDownChild.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownChild.TabIndex = 16;
            this.numericUpDownChild.ValueChanged += new System.EventHandler(this.numericUpDownChild_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rezervasyon yaptırılacak kişi sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Seçilen odaların mevcut kişi kapasitesi";
            // 
            // lblPersonNumber
            // 
            this.lblPersonNumber.AutoSize = true;
            this.lblPersonNumber.Location = new System.Drawing.Point(268, 20);
            this.lblPersonNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonNumber.Name = "lblPersonNumber";
            this.lblPersonNumber.Size = new System.Drawing.Size(0, 17);
            this.lblPersonNumber.TabIndex = 17;
            // 
            // lblRoomCapacities
            // 
            this.lblRoomCapacities.AutoSize = true;
            this.lblRoomCapacities.Location = new System.Drawing.Point(267, 62);
            this.lblRoomCapacities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomCapacities.Name = "lblRoomCapacities";
            this.lblRoomCapacities.Size = new System.Drawing.Size(16, 17);
            this.lblRoomCapacities.TabIndex = 17;
            this.lblRoomCapacities.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(168, 507);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 47);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grpReservations
            // 
            this.grpReservations.Location = new System.Drawing.Point(35, 87);
            this.grpReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReservations.Size = new System.Drawing.Size(224, 362);
            this.grpReservations.TabIndex = 18;
            this.grpReservations.TabStop = false;
            // 
            // lblwarning
            // 
            this.lblwarning.AllowDrop = true;
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(396, 11);
            this.lblwarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(745, 17);
            this.lblwarning.TabIndex = 17;
            this.lblwarning.Text = "Lütfen odaların toplam kişi kapasitesinin rezervasyon yapacağınız kişi adedine eş" +
    "it yada fazla olmasına dikkat ediniz!!!";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(188, 469);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(17, 17);
            this.lblTotalCost.TabIndex = 17;
            this.lblTotalCost.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 469);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Cost";
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.flpReservations);
            this.grpReservationDetails.Controls.Add(this.btnRemoveRoom);
            this.grpReservationDetails.Controls.Add(this.grpReservations);
            this.grpReservationDetails.Controls.Add(this.label6);
            this.grpReservationDetails.Controls.Add(this.btnNext);
            this.grpReservationDetails.Controls.Add(this.lblPersonNumber);
            this.grpReservationDetails.Controls.Add(this.lblTotalCost);
            this.grpReservationDetails.Controls.Add(this.lblRoomCapacities);
            this.grpReservationDetails.Controls.Add(this.label9);
            this.grpReservationDetails.Controls.Add(this.label7);
            this.grpReservationDetails.Location = new System.Drawing.Point(961, 41);
            this.grpReservationDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReservationDetails.Size = new System.Drawing.Size(317, 565);
            this.grpReservationDetails.TabIndex = 18;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation List";
            this.grpReservationDetails.Visible = false;
            // 
            // flpReservations
            // 
            this.flpReservations.Location = new System.Drawing.Point(25, 91);
            this.flpReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpReservations.Name = "flpReservations";
            this.flpReservations.Size = new System.Drawing.Size(243, 343);
            this.flpReservations.TabIndex = 1;
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveRoom.Location = new System.Drawing.Point(9, 507);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(151, 47);
            this.btnRemoveRoom.TabIndex = 19;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // flwPnl
            // 
            this.flwPnl.Location = new System.Drawing.Point(320, 48);
            this.flwPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flwPnl.Name = "flwPnl";
            this.flwPnl.Size = new System.Drawing.Size(633, 220);
            this.flwPnl.TabIndex = 1;
            this.flwPnl.Visible = false;
            // 
            // FormRezervasyonAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 672);
            this.Controls.Add(this.flwPnl);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.numericUpDownChild);
            this.Controls.Add(this.numericUpDownPerson);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.cmbRoomTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRezervasyonAnasayfa";
            this.Text = "Rezervasyon Anasayfa";
            this.Load += new System.EventHandler(this.FormRezervasyonAnasayfa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOdaResmi)).EndInit();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChild)).EndInit();
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomDescription;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRoomTypes;
        private System.Windows.Forms.PictureBox pcbOdaResmi;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPerson;
        private System.Windows.Forms.NumericUpDown numericUpDownChild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPersonNumber;
        private System.Windows.Forms.Label lblRoomCapacities;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpReservations;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.FlowLayoutPanel flpReservations;
        private System.Windows.Forms.FlowLayoutPanel flwPnl;
        private System.Windows.Forms.Button btnRemoveRoom;
    }
}