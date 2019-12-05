namespace danielCherrin_CarRentalApp
{
    partial class frm_CreateCustomer
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
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_streetName = new System.Windows.Forms.TextBox();
            this.txt_streetPostcode = new System.Windows.Forms.TextBox();
            this.txt_creditCardName = new System.Windows.Forms.TextBox();
            this.txt_creditCardNo = new System.Windows.Forms.TextBox();
            this.txt_mobPhone = new System.Windows.Forms.TextBox();
            this.txt_residencyState = new System.Windows.Forms.TextBox();
            this.txt_residencySuburb = new System.Windows.Forms.TextBox();
            this.txt_driverLicenseNo = new System.Windows.Forms.TextBox();
            this.dtp_creditCardExp = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelForm = new System.Windows.Forms.Button();
            this.btn_confirmForm = new System.Windows.Forms.Button();
            this.cmbo_creditCardType = new System.Windows.Forms.ComboBox();
            this.txt_streetNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(190, 38);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(261, 20);
            this.txt_firstName.TabIndex = 0;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(190, 64);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(261, 20);
            this.txt_lastName.TabIndex = 1;
            // 
            // txt_streetName
            // 
            this.txt_streetName.Location = new System.Drawing.Point(190, 116);
            this.txt_streetName.Name = "txt_streetName";
            this.txt_streetName.Size = new System.Drawing.Size(261, 20);
            this.txt_streetName.TabIndex = 3;
            // 
            // txt_streetPostcode
            // 
            this.txt_streetPostcode.Location = new System.Drawing.Point(190, 142);
            this.txt_streetPostcode.Name = "txt_streetPostcode";
            this.txt_streetPostcode.Size = new System.Drawing.Size(261, 20);
            this.txt_streetPostcode.TabIndex = 4;
            // 
            // txt_creditCardName
            // 
            this.txt_creditCardName.Location = new System.Drawing.Point(190, 272);
            this.txt_creditCardName.Name = "txt_creditCardName";
            this.txt_creditCardName.Size = new System.Drawing.Size(261, 20);
            this.txt_creditCardName.TabIndex = 9;
            // 
            // txt_creditCardNo
            // 
            this.txt_creditCardNo.Location = new System.Drawing.Point(190, 246);
            this.txt_creditCardNo.Name = "txt_creditCardNo";
            this.txt_creditCardNo.Size = new System.Drawing.Size(261, 20);
            this.txt_creditCardNo.TabIndex = 8;
            // 
            // txt_mobPhone
            // 
            this.txt_mobPhone.Location = new System.Drawing.Point(190, 220);
            this.txt_mobPhone.Name = "txt_mobPhone";
            this.txt_mobPhone.Size = new System.Drawing.Size(261, 20);
            this.txt_mobPhone.TabIndex = 7;
            // 
            // txt_residencyState
            // 
            this.txt_residencyState.Location = new System.Drawing.Point(190, 194);
            this.txt_residencyState.Name = "txt_residencyState";
            this.txt_residencyState.Size = new System.Drawing.Size(261, 20);
            this.txt_residencyState.TabIndex = 6;
            // 
            // txt_residencySuburb
            // 
            this.txt_residencySuburb.Location = new System.Drawing.Point(190, 168);
            this.txt_residencySuburb.Name = "txt_residencySuburb";
            this.txt_residencySuburb.Size = new System.Drawing.Size(261, 20);
            this.txt_residencySuburb.TabIndex = 5;
            // 
            // txt_driverLicenseNo
            // 
            this.txt_driverLicenseNo.Location = new System.Drawing.Point(190, 351);
            this.txt_driverLicenseNo.Name = "txt_driverLicenseNo";
            this.txt_driverLicenseNo.Size = new System.Drawing.Size(261, 20);
            this.txt_driverLicenseNo.TabIndex = 12;
            // 
            // dtp_creditCardExp
            // 
            this.dtp_creditCardExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_creditCardExp.Location = new System.Drawing.Point(190, 325);
            this.dtp_creditCardExp.Name = "dtp_creditCardExp";
            this.dtp_creditCardExp.Size = new System.Drawing.Size(261, 20);
            this.dtp_creditCardExp.TabIndex = 11;
            // 
            // btn_cancelForm
            // 
            this.btn_cancelForm.Location = new System.Drawing.Point(376, 447);
            this.btn_cancelForm.Name = "btn_cancelForm";
            this.btn_cancelForm.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelForm.TabIndex = 14;
            this.btn_cancelForm.Text = "Cancel";
            this.btn_cancelForm.UseVisualStyleBackColor = true;
            this.btn_cancelForm.Click += new System.EventHandler(this.btn_CancelForm_Click);
            // 
            // btn_confirmForm
            // 
            this.btn_confirmForm.Location = new System.Drawing.Point(190, 447);
            this.btn_confirmForm.Name = "btn_confirmForm";
            this.btn_confirmForm.Size = new System.Drawing.Size(180, 23);
            this.btn_confirmForm.TabIndex = 15;
            this.btn_confirmForm.Text = "Register customer";
            this.btn_confirmForm.UseVisualStyleBackColor = true;
            this.btn_confirmForm.Click += new System.EventHandler(this.btn_confirmForm_Click);
            // 
            // cmbo_creditCardType
            // 
            this.cmbo_creditCardType.FormattingEnabled = true;
            this.cmbo_creditCardType.Items.AddRange(new object[] {
            "Tiscover",
            "Merican Expresso",
            "Bisa",
            "RasterCard"});
            this.cmbo_creditCardType.Location = new System.Drawing.Point(190, 298);
            this.cmbo_creditCardType.Name = "cmbo_creditCardType";
            this.cmbo_creditCardType.Size = new System.Drawing.Size(261, 21);
            this.cmbo_creditCardType.TabIndex = 10;
            // 
            // txt_streetNo
            // 
            this.txt_streetNo.Location = new System.Drawing.Point(190, 90);
            this.txt_streetNo.Name = "txt_streetNo";
            this.txt_streetNo.Size = new System.Drawing.Size(261, 20);
            this.txt_streetNo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Credit Card Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Credit Card No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Residency State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Residency Suburb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Street PostCode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Street Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Street No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Credit Card Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Credit Card Exp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Mob. Phone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "Driver Licence";
            // 
            // frm_CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 507);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_streetNo);
            this.Controls.Add(this.cmbo_creditCardType);
            this.Controls.Add(this.btn_confirmForm);
            this.Controls.Add(this.btn_cancelForm);
            this.Controls.Add(this.dtp_creditCardExp);
            this.Controls.Add(this.txt_driverLicenseNo);
            this.Controls.Add(this.txt_creditCardName);
            this.Controls.Add(this.txt_creditCardNo);
            this.Controls.Add(this.txt_mobPhone);
            this.Controls.Add(this.txt_residencyState);
            this.Controls.Add(this.txt_residencySuburb);
            this.Controls.Add(this.txt_streetPostcode);
            this.Controls.Add(this.txt_streetName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Name = "frm_CreateCustomer";
            this.Text = "Create customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_streetName;
        private System.Windows.Forms.TextBox txt_streetPostcode;
        private System.Windows.Forms.TextBox txt_creditCardName;
        private System.Windows.Forms.TextBox txt_creditCardNo;
        private System.Windows.Forms.TextBox txt_mobPhone;
        private System.Windows.Forms.TextBox txt_residencyState;
        private System.Windows.Forms.TextBox txt_residencySuburb;
        private System.Windows.Forms.TextBox txt_driverLicenseNo;
        private System.Windows.Forms.DateTimePicker dtp_creditCardExp;
        private System.Windows.Forms.Button btn_cancelForm;
        private System.Windows.Forms.Button btn_confirmForm;
        private System.Windows.Forms.ComboBox cmbo_creditCardType;
        private System.Windows.Forms.TextBox txt_streetNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}