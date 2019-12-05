namespace danielCherrin_CarRentalApp
{
    partial class frm_CustomerDGV
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
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.btn_alterCustomer = new System.Windows.Forms.Button();
            this.btn_refreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToDeleteRows = false;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(19, 20);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.Size = new System.Drawing.Size(1187, 561);
            this.dgv_Customers.TabIndex = 1;
            this.dgv_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customers_CellClick);
            // 
            // btn_alterCustomer
            // 
            this.btn_alterCustomer.Enabled = false;
            this.btn_alterCustomer.Location = new System.Drawing.Point(1225, 20);
            this.btn_alterCustomer.Name = "btn_alterCustomer";
            this.btn_alterCustomer.Size = new System.Drawing.Size(160, 84);
            this.btn_alterCustomer.TabIndex = 2;
            this.btn_alterCustomer.Text = "Alter Customer";
            this.btn_alterCustomer.UseVisualStyleBackColor = true;
            this.btn_alterCustomer.Click += new System.EventHandler(this.btn_alterCustomer_Click);
            // 
            // btn_refreshDGV
            // 
            this.btn_refreshDGV.Location = new System.Drawing.Point(1225, 110);
            this.btn_refreshDGV.Name = "btn_refreshDGV";
            this.btn_refreshDGV.Size = new System.Drawing.Size(160, 84);
            this.btn_refreshDGV.TabIndex = 3;
            this.btn_refreshDGV.Text = "Refresh DGV";
            this.btn_refreshDGV.UseVisualStyleBackColor = true;
            this.btn_refreshDGV.Click += new System.EventHandler(this.btn_refreshDGV_Click);
            // 
            // frm_CustomerDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 600);
            this.Controls.Add(this.btn_refreshDGV);
            this.Controls.Add(this.btn_alterCustomer);
            this.Controls.Add(this.dgv_Customers);
            this.Name = "frm_CustomerDGV";
            this.Text = "Customer DGV";
            this.Load += new System.EventHandler(this.frm_CustomerDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Button btn_alterCustomer;
        private System.Windows.Forms.Button btn_refreshDGV;
    }
}