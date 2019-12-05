namespace danielCherrin_CarRentalApp
{
    partial class frm_LoginCustomer
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
            this.btn_NewCustomer = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.dsgn_BOX = new System.Windows.Forms.Label();
            this.lbl_LOGIN_EXISTING_CUSTOMER = new System.Windows.Forms.Label();
            this.txtbx_DriverLicenseNo = new System.Windows.Forms.TextBox();
            this.lbl_DRIVER_LICENSE_NO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NewCustomer
            // 
            this.btn_NewCustomer.Location = new System.Drawing.Point(223, 106);
            this.btn_NewCustomer.Name = "btn_NewCustomer";
            this.btn_NewCustomer.Size = new System.Drawing.Size(155, 26);
            this.btn_NewCustomer.TabIndex = 0;
            this.btn_NewCustomer.Text = "Register New Customer";
            this.btn_NewCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(291, 58);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(68, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // dsgn_BOX
            // 
            this.dsgn_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dsgn_BOX.Location = new System.Drawing.Point(12, 16);
            this.dsgn_BOX.Name = "dsgn_BOX";
            this.dsgn_BOX.Size = new System.Drawing.Size(366, 78);
            this.dsgn_BOX.TabIndex = 2;
            // 
            // lbl_LOGIN_EXISTING_CUSTOMER
            // 
            this.lbl_LOGIN_EXISTING_CUSTOMER.AutoSize = true;
            this.lbl_LOGIN_EXISTING_CUSTOMER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LOGIN_EXISTING_CUSTOMER.Location = new System.Drawing.Point(19, 10);
            this.lbl_LOGIN_EXISTING_CUSTOMER.Name = "lbl_LOGIN_EXISTING_CUSTOMER";
            this.lbl_LOGIN_EXISTING_CUSTOMER.Size = new System.Drawing.Size(121, 15);
            this.lbl_LOGIN_EXISTING_CUSTOMER.TabIndex = 3;
            this.lbl_LOGIN_EXISTING_CUSTOMER.Text = "Login Existing Customer";
            // 
            // txtbx_DriverLicenseNo
            // 
            this.txtbx_DriverLicenseNo.Location = new System.Drawing.Point(128, 32);
            this.txtbx_DriverLicenseNo.Name = "txtbx_DriverLicenseNo";
            this.txtbx_DriverLicenseNo.Size = new System.Drawing.Size(231, 20);
            this.txtbx_DriverLicenseNo.TabIndex = 4;
            // 
            // lbl_DRIVER_LICENSE_NO
            // 
            this.lbl_DRIVER_LICENSE_NO.AutoSize = true;
            this.lbl_DRIVER_LICENSE_NO.Location = new System.Drawing.Point(27, 35);
            this.lbl_DRIVER_LICENSE_NO.Name = "lbl_DRIVER_LICENSE_NO";
            this.lbl_DRIVER_LICENSE_NO.Size = new System.Drawing.Size(95, 13);
            this.lbl_DRIVER_LICENSE_NO.TabIndex = 5;
            this.lbl_DRIVER_LICENSE_NO.Text = "Driver License No.";
            // 
            // frm_LoginCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 144);
            this.Controls.Add(this.lbl_DRIVER_LICENSE_NO);
            this.Controls.Add(this.txtbx_DriverLicenseNo);
            this.Controls.Add(this.lbl_LOGIN_EXISTING_CUSTOMER);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_NewCustomer);
            this.Controls.Add(this.dsgn_BOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_LoginCustomer";
            this.Text = "Customer Login.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewCustomer;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label dsgn_BOX;
        private System.Windows.Forms.Label lbl_LOGIN_EXISTING_CUSTOMER;
        private System.Windows.Forms.TextBox txtbx_DriverLicenseNo;
        private System.Windows.Forms.Label lbl_DRIVER_LICENSE_NO;
    }
}

