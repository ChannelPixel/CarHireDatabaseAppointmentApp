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
            this.dgv_Home = new System.Windows.Forms.DataGridView();
            this.btn_createCustomer = new System.Windows.Forms.Button();
            this.btn_createVehicle = new System.Windows.Forms.Button();
            this.btn_createContract = new System.Windows.Forms.Button();
            this.dtp_contractsSearchFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_searchContracts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_customerDGV = new System.Windows.Forms.Button();
            this.btn_vehicleDGV = new System.Windows.Forms.Button();
            this.btn_contractDGV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alterAppointment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Home
            // 
            this.dgv_Home.AllowUserToAddRows = false;
            this.dgv_Home.AllowUserToDeleteRows = false;
            this.dgv_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home.Location = new System.Drawing.Point(19, 20);
            this.dgv_Home.Name = "dgv_Home";
            this.dgv_Home.ReadOnly = true;
            this.dgv_Home.Size = new System.Drawing.Size(1187, 561);
            this.dgv_Home.TabIndex = 0;
            this.dgv_Home.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Home_CellClick);
            // 
            // btn_createCustomer
            // 
            this.btn_createCustomer.Location = new System.Drawing.Point(13, 78);
            this.btn_createCustomer.Name = "btn_createCustomer";
            this.btn_createCustomer.Size = new System.Drawing.Size(132, 42);
            this.btn_createCustomer.TabIndex = 0;
            this.btn_createCustomer.Text = "Create Customer";
            this.btn_createCustomer.UseVisualStyleBackColor = true;
            this.btn_createCustomer.Click += new System.EventHandler(this.btn_createCustomer_Click);
            // 
            // btn_createVehicle
            // 
            this.btn_createVehicle.Location = new System.Drawing.Point(13, 126);
            this.btn_createVehicle.Name = "btn_createVehicle";
            this.btn_createVehicle.Size = new System.Drawing.Size(132, 42);
            this.btn_createVehicle.TabIndex = 1;
            this.btn_createVehicle.Text = "Create Vehicle";
            this.btn_createVehicle.UseVisualStyleBackColor = true;
            this.btn_createVehicle.Click += new System.EventHandler(this.btn_createVehicle_Click);
            // 
            // btn_createContract
            // 
            this.btn_createContract.Location = new System.Drawing.Point(13, 30);
            this.btn_createContract.Name = "btn_createContract";
            this.btn_createContract.Size = new System.Drawing.Size(132, 42);
            this.btn_createContract.TabIndex = 2;
            this.btn_createContract.Text = "Create Contract";
            this.btn_createContract.UseVisualStyleBackColor = true;
            this.btn_createContract.Click += new System.EventHandler(this.btn_createContract_Click);
            // 
            // dtp_contractsSearchFrom
            // 
            this.dtp_contractsSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_contractsSearchFrom.Location = new System.Drawing.Point(12, 51);
            this.dtp_contractsSearchFrom.Name = "dtp_contractsSearchFrom";
            this.dtp_contractsSearchFrom.Size = new System.Drawing.Size(92, 20);
            this.dtp_contractsSearchFrom.TabIndex = 3;
            // 
            // btn_searchContracts
            // 
            this.btn_searchContracts.Location = new System.Drawing.Point(12, 77);
            this.btn_searchContracts.Name = "btn_searchContracts";
            this.btn_searchContracts.Size = new System.Drawing.Size(132, 42);
            this.btn_searchContracts.TabIndex = 4;
            this.btn_searchContracts.Text = "Search appointments";
            this.btn_searchContracts.UseVisualStyleBackColor = true;
            this.btn_searchContracts.Click += new System.EventHandler(this.btn_searchContracts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Display appointments \r\nonwards from:";
            // 
            // btn_customerDGV
            // 
            this.btn_customerDGV.Location = new System.Drawing.Point(13, 78);
            this.btn_customerDGV.Name = "btn_customerDGV";
            this.btn_customerDGV.Size = new System.Drawing.Size(132, 42);
            this.btn_customerDGV.TabIndex = 6;
            this.btn_customerDGV.Text = "Show Customer DGV";
            this.btn_customerDGV.UseVisualStyleBackColor = true;
            this.btn_customerDGV.Click += new System.EventHandler(this.btn_customerDGV_Click);
            // 
            // btn_vehicleDGV
            // 
            this.btn_vehicleDGV.Location = new System.Drawing.Point(13, 126);
            this.btn_vehicleDGV.Name = "btn_vehicleDGV";
            this.btn_vehicleDGV.Size = new System.Drawing.Size(132, 42);
            this.btn_vehicleDGV.TabIndex = 7;
            this.btn_vehicleDGV.Text = "Show Vehicle DGV";
            this.btn_vehicleDGV.UseVisualStyleBackColor = true;
            this.btn_vehicleDGV.Click += new System.EventHandler(this.btn_vehicleDGV_Click);
            // 
            // btn_contractDGV
            // 
            this.btn_contractDGV.Location = new System.Drawing.Point(13, 30);
            this.btn_contractDGV.Name = "btn_contractDGV";
            this.btn_contractDGV.Size = new System.Drawing.Size(132, 42);
            this.btn_contractDGV.TabIndex = 8;
            this.btn_contractDGV.Text = "Show Contract DGV";
            this.btn_contractDGV.UseVisualStyleBackColor = true;
            this.btn_contractDGV.Click += new System.EventHandler(this.btn_contractDGV_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_alterAppointment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_contractsSearchFrom);
            this.panel1.Controls.Add(this.btn_searchContracts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(1225, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 183);
            this.panel1.TabIndex = 9;
            // 
            // btn_alterAppointment
            // 
            this.btn_alterAppointment.Enabled = false;
            this.btn_alterAppointment.Location = new System.Drawing.Point(13, 125);
            this.btn_alterAppointment.Name = "btn_alterAppointment";
            this.btn_alterAppointment.Size = new System.Drawing.Size(132, 42);
            this.btn_alterAppointment.TabIndex = 11;
            this.btn_alterAppointment.Text = "Alter appointment";
            this.btn_alterAppointment.UseVisualStyleBackColor = true;
            this.btn_alterAppointment.Click += new System.EventHandler(this.btn_alterAppointment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search appointments";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_createVehicle);
            this.panel2.Controls.Add(this.btn_createCustomer);
            this.panel2.Controls.Add(this.btn_createContract);
            this.panel2.Location = new System.Drawing.Point(1225, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 183);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-1, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Create options";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_vehicleDGV);
            this.panel3.Controls.Add(this.btn_customerDGV);
            this.panel3.Controls.Add(this.btn_contractDGV);
            this.panel3.Location = new System.Drawing.Point(1225, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 183);
            this.panel3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(-1, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alter DGV options";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Home);
            this.Name = "frm_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Home;
        private System.Windows.Forms.Button btn_createCustomer;
        private System.Windows.Forms.Button btn_createVehicle;
        private System.Windows.Forms.Button btn_createContract;
        private System.Windows.Forms.DateTimePicker dtp_contractsSearchFrom;
        private System.Windows.Forms.Button btn_searchContracts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_customerDGV;
        private System.Windows.Forms.Button btn_vehicleDGV;
        private System.Windows.Forms.Button btn_contractDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_alterAppointment;
    }
}

