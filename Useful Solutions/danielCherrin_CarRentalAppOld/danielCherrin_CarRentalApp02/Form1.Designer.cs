namespace danielCherrin_CarRentalApp
{
    partial class frm_Home
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
            this.btn_SearchContractsRefine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_SearchContractsDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_Home = new System.Windows.Forms.DataGridView();
            this.txt_SearchContractsLicenseNo = new System.Windows.Forms.TextBox();
            this.dtp_SearchVehiclesTo = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtp_SearchVehiclesFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_SearchVehiclesColor = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_SearchVehiclesModel = new System.Windows.Forms.TextBox();
            this.txt_SearchVehiclesManufacturer = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_SearchVehiclesReset = new System.Windows.Forms.Button();
            this.txt_SearchVehiclesVIN = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.rbtn_SearchContractsLicenseNo = new System.Windows.Forms.RadioButton();
            this.rbtn_SearchContractsLastName = new System.Windows.Forms.RadioButton();
            this.txt_SearchContractsLastName = new System.Windows.Forms.TextBox();
            this.pnl_SearchContracts = new System.Windows.Forms.Panel();
            this.btn_SearchContractsToday = new System.Windows.Forms.Button();
            this.btn_SearchContractsFull = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_ContractOptions = new System.Windows.Forms.Panel();
            this.btn_AlterContractFrm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AlterContractContractNo = new System.Windows.Forms.TextBox();
            this.btn_CreateContractFrm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_SearchVehiclesBodyType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).BeginInit();
            this.pnl_SearchContracts.SuspendLayout();
            this.pnl_ContractOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SearchContractsRefine
            // 
            this.btn_SearchContractsRefine.Location = new System.Drawing.Point(23, 210);
            this.btn_SearchContractsRefine.Name = "btn_SearchContractsRefine";
            this.btn_SearchContractsRefine.Size = new System.Drawing.Size(153, 43);
            this.btn_SearchContractsRefine.TabIndex = 7;
            this.btn_SearchContractsRefine.Text = "Search";
            this.btn_SearchContractsRefine.UseVisualStyleBackColor = true;
            this.btn_SearchContractsRefine.Click += new System.EventHandler(this.btn_SearchContracts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contracts from this date onwards";
            // 
            // dtp_SearchContractsDate
            // 
            this.dtp_SearchContractsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_SearchContractsDate.Location = new System.Drawing.Point(24, 41);
            this.dtp_SearchContractsDate.Name = "dtp_SearchContractsDate";
            this.dtp_SearchContractsDate.Size = new System.Drawing.Size(151, 20);
            this.dtp_SearchContractsDate.TabIndex = 5;
            // 
            // dgv_Home
            // 
            this.dgv_Home.AllowUserToAddRows = false;
            this.dgv_Home.AllowUserToDeleteRows = false;
            this.dgv_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home.Location = new System.Drawing.Point(12, 12);
            this.dgv_Home.Name = "dgv_Home";
            this.dgv_Home.ReadOnly = true;
            this.dgv_Home.Size = new System.Drawing.Size(1236, 272);
            this.dgv_Home.TabIndex = 4;
            this.dgv_Home.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Home_CellClick);
            // 
            // txt_SearchContractsLicenseNo
            // 
            this.txt_SearchContractsLicenseNo.Location = new System.Drawing.Point(23, 105);
            this.txt_SearchContractsLicenseNo.Name = "txt_SearchContractsLicenseNo";
            this.txt_SearchContractsLicenseNo.ReadOnly = true;
            this.txt_SearchContractsLicenseNo.Size = new System.Drawing.Size(152, 20);
            this.txt_SearchContractsLicenseNo.TabIndex = 9;
            // 
            // dtp_SearchVehiclesTo
            // 
            this.dtp_SearchVehiclesTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_SearchVehiclesTo.Location = new System.Drawing.Point(144, 176);
            this.dtp_SearchVehiclesTo.Name = "dtp_SearchVehiclesTo";
            this.dtp_SearchVehiclesTo.Size = new System.Drawing.Size(128, 20);
            this.dtp_SearchVehiclesTo.TabIndex = 70;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(115, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "TO";
            // 
            // dtp_SearchVehiclesFrom
            // 
            this.dtp_SearchVehiclesFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_SearchVehiclesFrom.Location = new System.Drawing.Point(144, 150);
            this.dtp_SearchVehiclesFrom.Name = "dtp_SearchVehiclesFrom";
            this.dtp_SearchVehiclesFrom.Size = new System.Drawing.Size(128, 20);
            this.dtp_SearchVehiclesFrom.TabIndex = 68;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "Available FROM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "Body Type";
            // 
            // txt_SearchVehiclesColor
            // 
            this.txt_SearchVehiclesColor.Location = new System.Drawing.Point(144, 98);
            this.txt_SearchVehiclesColor.Name = "txt_SearchVehiclesColor";
            this.txt_SearchVehiclesColor.Size = new System.Drawing.Size(128, 20);
            this.txt_SearchVehiclesColor.TabIndex = 62;
            this.txt_SearchVehiclesColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Color";
            // 
            // txt_SearchVehiclesModel
            // 
            this.txt_SearchVehiclesModel.Location = new System.Drawing.Point(144, 72);
            this.txt_SearchVehiclesModel.Name = "txt_SearchVehiclesModel";
            this.txt_SearchVehiclesModel.Size = new System.Drawing.Size(128, 20);
            this.txt_SearchVehiclesModel.TabIndex = 60;
            this.txt_SearchVehiclesModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SearchVehiclesManufacturer
            // 
            this.txt_SearchVehiclesManufacturer.Location = new System.Drawing.Point(144, 46);
            this.txt_SearchVehiclesManufacturer.Name = "txt_SearchVehiclesManufacturer";
            this.txt_SearchVehiclesManufacturer.Size = new System.Drawing.Size(128, 20);
            this.txt_SearchVehiclesManufacturer.TabIndex = 59;
            this.txt_SearchVehiclesManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Model";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Manufacturer";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 43);
            this.button7.TabIndex = 56;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(452, 300);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 15);
            this.label23.TabIndex = 65;
            this.label23.Text = "Search Vehicle/s";
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(1040, 307);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(287, 297);
            this.label24.TabIndex = 66;
            // 
            // btn_SearchVehiclesReset
            // 
            this.btn_SearchVehiclesReset.Location = new System.Drawing.Point(22, 259);
            this.btn_SearchVehiclesReset.Name = "btn_SearchVehiclesReset";
            this.btn_SearchVehiclesReset.Size = new System.Drawing.Size(250, 91);
            this.btn_SearchVehiclesReset.TabIndex = 72;
            this.btn_SearchVehiclesReset.Text = "Reset /\r\nShow Full Vehicle List";
            this.btn_SearchVehiclesReset.UseVisualStyleBackColor = true;
            // 
            // txt_SearchVehiclesVIN
            // 
            this.txt_SearchVehiclesVIN.Location = new System.Drawing.Point(144, 20);
            this.txt_SearchVehiclesVIN.Name = "txt_SearchVehiclesVIN";
            this.txt_SearchVehiclesVIN.Size = new System.Drawing.Size(128, 20);
            this.txt_SearchVehiclesVIN.TabIndex = 74;
            this.txt_SearchVehiclesVIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 13);
            this.label25.TabIndex = 73;
            this.label25.Text = "VIN";
            // 
            // rbtn_SearchContractsLicenseNo
            // 
            this.rbtn_SearchContractsLicenseNo.AutoSize = true;
            this.rbtn_SearchContractsLicenseNo.Location = new System.Drawing.Point(23, 73);
            this.rbtn_SearchContractsLicenseNo.Name = "rbtn_SearchContractsLicenseNo";
            this.rbtn_SearchContractsLicenseNo.Size = new System.Drawing.Size(123, 30);
            this.rbtn_SearchContractsLicenseNo.TabIndex = 78;
            this.rbtn_SearchContractsLicenseNo.TabStop = true;
            this.rbtn_SearchContractsLicenseNo.Text = "Driver\'s License No. \r\n(Search Customer)";
            this.rbtn_SearchContractsLicenseNo.UseVisualStyleBackColor = true;
            this.rbtn_SearchContractsLicenseNo.CheckedChanged += new System.EventHandler(this.rbtn_SearchContractsLicenseNo_CheckedChanged);
            // 
            // rbtn_SearchContractsLastName
            // 
            this.rbtn_SearchContractsLastName.AutoSize = true;
            this.rbtn_SearchContractsLastName.Location = new System.Drawing.Point(24, 138);
            this.rbtn_SearchContractsLastName.Name = "rbtn_SearchContractsLastName";
            this.rbtn_SearchContractsLastName.Size = new System.Drawing.Size(123, 30);
            this.rbtn_SearchContractsLastName.TabIndex = 79;
            this.rbtn_SearchContractsLastName.TabStop = true;
            this.rbtn_SearchContractsLastName.Text = "Customer Last Name\r\n(Search Customer)";
            this.rbtn_SearchContractsLastName.UseVisualStyleBackColor = true;
            this.rbtn_SearchContractsLastName.CheckedChanged += new System.EventHandler(this.rbtn_SearchContractsLastName_CheckedChanged);
            // 
            // txt_SearchContractsLastName
            // 
            this.txt_SearchContractsLastName.Location = new System.Drawing.Point(23, 174);
            this.txt_SearchContractsLastName.Name = "txt_SearchContractsLastName";
            this.txt_SearchContractsLastName.ReadOnly = true;
            this.txt_SearchContractsLastName.Size = new System.Drawing.Size(151, 20);
            this.txt_SearchContractsLastName.TabIndex = 80;
            // 
            // pnl_SearchContracts
            // 
            this.pnl_SearchContracts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SearchContracts.Controls.Add(this.btn_SearchContractsToday);
            this.pnl_SearchContracts.Controls.Add(this.btn_SearchContractsFull);
            this.pnl_SearchContracts.Controls.Add(this.rbtn_SearchContractsLicenseNo);
            this.pnl_SearchContracts.Controls.Add(this.label1);
            this.pnl_SearchContracts.Controls.Add(this.txt_SearchContractsLastName);
            this.pnl_SearchContracts.Controls.Add(this.dtp_SearchContractsDate);
            this.pnl_SearchContracts.Controls.Add(this.btn_SearchContractsRefine);
            this.pnl_SearchContracts.Controls.Add(this.txt_SearchContractsLicenseNo);
            this.pnl_SearchContracts.Controls.Add(this.rbtn_SearchContractsLastName);
            this.pnl_SearchContracts.Location = new System.Drawing.Point(12, 307);
            this.pnl_SearchContracts.Name = "pnl_SearchContracts";
            this.pnl_SearchContracts.Size = new System.Drawing.Size(201, 377);
            this.pnl_SearchContracts.TabIndex = 87;
            // 
            // btn_SearchContractsToday
            // 
            this.btn_SearchContractsToday.Location = new System.Drawing.Point(24, 308);
            this.btn_SearchContractsToday.Name = "btn_SearchContractsToday";
            this.btn_SearchContractsToday.Size = new System.Drawing.Size(151, 43);
            this.btn_SearchContractsToday.TabIndex = 82;
            this.btn_SearchContractsToday.Text = "Reset / \r\nShow Today\'s Contract List";
            this.btn_SearchContractsToday.UseVisualStyleBackColor = true;
            this.btn_SearchContractsToday.Click += new System.EventHandler(this.btn_SearchContractsToday_Click);
            // 
            // btn_SearchContractsFull
            // 
            this.btn_SearchContractsFull.Location = new System.Drawing.Point(23, 259);
            this.btn_SearchContractsFull.Name = "btn_SearchContractsFull";
            this.btn_SearchContractsFull.Size = new System.Drawing.Size(153, 43);
            this.btn_SearchContractsFull.TabIndex = 81;
            this.btn_SearchContractsFull.Text = "Show Full Contract List";
            this.btn_SearchContractsFull.UseVisualStyleBackColor = true;
            this.btn_SearchContractsFull.Click += new System.EventHandler(this.btn_SearchContractsFull_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(19, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 88;
            this.label5.Text = "Search Contracts";
            // 
            // pnl_ContractOptions
            // 
            this.pnl_ContractOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ContractOptions.Controls.Add(this.btn_AlterContractFrm);
            this.pnl_ContractOptions.Controls.Add(this.label6);
            this.pnl_ContractOptions.Controls.Add(this.txt_AlterContractContractNo);
            this.pnl_ContractOptions.Controls.Add(this.btn_CreateContractFrm);
            this.pnl_ContractOptions.Location = new System.Drawing.Point(228, 307);
            this.pnl_ContractOptions.Name = "pnl_ContractOptions";
            this.pnl_ContractOptions.Size = new System.Drawing.Size(201, 377);
            this.pnl_ContractOptions.TabIndex = 89;
            // 
            // btn_AlterContractFrm
            // 
            this.btn_AlterContractFrm.Enabled = false;
            this.btn_AlterContractFrm.Location = new System.Drawing.Point(20, 259);
            this.btn_AlterContractFrm.Name = "btn_AlterContractFrm";
            this.btn_AlterContractFrm.Size = new System.Drawing.Size(153, 92);
            this.btn_AlterContractFrm.TabIndex = 30;
            this.btn_AlterContractFrm.Text = "Alter Contract";
            this.btn_AlterContractFrm.UseVisualStyleBackColor = true;
            this.btn_AlterContractFrm.Click += new System.EventHandler(this.btn_AlterContractFrm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 86;
            this.label6.Text = "Contract No. \r\n(Alter Contract)";
            // 
            // txt_AlterContractContractNo
            // 
            this.txt_AlterContractContractNo.Location = new System.Drawing.Point(19, 233);
            this.txt_AlterContractContractNo.Name = "txt_AlterContractContractNo";
            this.txt_AlterContractContractNo.ReadOnly = true;
            this.txt_AlterContractContractNo.Size = new System.Drawing.Size(151, 20);
            this.txt_AlterContractContractNo.TabIndex = 39;
            this.txt_AlterContractContractNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_CreateContractFrm
            // 
            this.btn_CreateContractFrm.Location = new System.Drawing.Point(19, 22);
            this.btn_CreateContractFrm.Name = "btn_CreateContractFrm";
            this.btn_CreateContractFrm.Size = new System.Drawing.Size(153, 103);
            this.btn_CreateContractFrm.TabIndex = 33;
            this.btn_CreateContractFrm.Text = "Create Contract";
            this.btn_CreateContractFrm.UseVisualStyleBackColor = true;
            this.btn_CreateContractFrm.Click += new System.EventHandler(this.btn_CreateContractFrm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(235, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 90;
            this.label7.Text = "Contract Options";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_SearchVehiclesBodyType);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txt_SearchVehiclesManufacturer);
            this.panel1.Controls.Add(this.txt_SearchVehiclesVIN);
            this.panel1.Controls.Add(this.txt_SearchVehiclesModel);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btn_SearchVehiclesReset);
            this.panel1.Controls.Add(this.txt_SearchVehiclesColor);
            this.panel1.Controls.Add(this.dtp_SearchVehiclesTo);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dtp_SearchVehiclesFrom);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(445, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 377);
            this.panel1.TabIndex = 91;
            // 
            // cmb_SearchVehiclesBodyType
            // 
            this.cmb_SearchVehiclesBodyType.FormattingEnabled = true;
            this.cmb_SearchVehiclesBodyType.Items.AddRange(new object[] {
            "Sports Car",
            "Utility",
            "SUV",
            "Station Wagon",
            "Sedan"});
            this.cmb_SearchVehiclesBodyType.Location = new System.Drawing.Point(144, 123);
            this.cmb_SearchVehiclesBodyType.Name = "cmb_SearchVehiclesBodyType";
            this.cmb_SearchVehiclesBodyType.Size = new System.Drawing.Size(128, 21);
            this.cmb_SearchVehiclesBodyType.TabIndex = 93;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1061);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnl_ContractOptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgv_Home);
            this.Controls.Add(this.pnl_SearchContracts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Home";
            this.Text = "CarRentalApp";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).EndInit();
            this.pnl_SearchContracts.ResumeLayout(false);
            this.pnl_SearchContracts.PerformLayout();
            this.pnl_ContractOptions.ResumeLayout(false);
            this.pnl_ContractOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchContractsRefine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_SearchContractsDate;
        private System.Windows.Forms.DataGridView dgv_Home;
        private System.Windows.Forms.TextBox txt_SearchContractsLicenseNo;
        private System.Windows.Forms.DateTimePicker dtp_SearchVehiclesTo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtp_SearchVehiclesFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_SearchVehiclesColor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_SearchVehiclesModel;
        private System.Windows.Forms.TextBox txt_SearchVehiclesManufacturer;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_SearchVehiclesReset;
        private System.Windows.Forms.TextBox txt_SearchVehiclesVIN;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton rbtn_SearchContractsLicenseNo;
        private System.Windows.Forms.RadioButton rbtn_SearchContractsLastName;
        private System.Windows.Forms.TextBox txt_SearchContractsLastName;
        private System.Windows.Forms.Panel pnl_SearchContracts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_ContractOptions;
        private System.Windows.Forms.Button btn_AlterContractFrm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_AlterContractContractNo;
        private System.Windows.Forms.Button btn_CreateContractFrm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SearchContractsFull;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_SearchVehiclesBodyType;
        private System.Windows.Forms.Button btn_SearchContractsToday;
    }
}