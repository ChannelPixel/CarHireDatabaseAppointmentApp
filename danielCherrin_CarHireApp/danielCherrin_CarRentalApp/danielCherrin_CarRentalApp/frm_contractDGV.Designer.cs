namespace danielCherrin_CarRentalApp
{
    partial class frm_ContractDGV
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
            this.dgv_Contracts = new System.Windows.Forms.DataGridView();
            this.btn_alterContract = new System.Windows.Forms.Button();
            this.btn_refreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Contracts
            // 
            this.dgv_Contracts.AllowUserToAddRows = false;
            this.dgv_Contracts.AllowUserToDeleteRows = false;
            this.dgv_Contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Contracts.Location = new System.Drawing.Point(19, 20);
            this.dgv_Contracts.Name = "dgv_Contracts";
            this.dgv_Contracts.ReadOnly = true;
            this.dgv_Contracts.Size = new System.Drawing.Size(1187, 561);
            this.dgv_Contracts.TabIndex = 0;
            this.dgv_Contracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Contracts_CellClick);
            // 
            // btn_alterContract
            // 
            this.btn_alterContract.Enabled = false;
            this.btn_alterContract.Location = new System.Drawing.Point(1225, 20);
            this.btn_alterContract.Name = "btn_alterContract";
            this.btn_alterContract.Size = new System.Drawing.Size(160, 84);
            this.btn_alterContract.TabIndex = 1;
            this.btn_alterContract.Text = "Alter Contract";
            this.btn_alterContract.UseVisualStyleBackColor = true;
            this.btn_alterContract.Click += new System.EventHandler(this.btn_alterContract_Click);
            // 
            // btn_refreshDGV
            // 
            this.btn_refreshDGV.Location = new System.Drawing.Point(1225, 110);
            this.btn_refreshDGV.Name = "btn_refreshDGV";
            this.btn_refreshDGV.Size = new System.Drawing.Size(160, 84);
            this.btn_refreshDGV.TabIndex = 2;
            this.btn_refreshDGV.Text = "Refresh DGV";
            this.btn_refreshDGV.UseVisualStyleBackColor = true;
            this.btn_refreshDGV.Click += new System.EventHandler(this.btn_refreshDGV_Click);
            // 
            // frm_ContractDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 600);
            this.Controls.Add(this.btn_refreshDGV);
            this.Controls.Add(this.btn_alterContract);
            this.Controls.Add(this.dgv_Contracts);
            this.Name = "frm_ContractDGV";
            this.Text = "Contract DGV";
            this.Load += new System.EventHandler(this.frm_ContractDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Contracts;
        private System.Windows.Forms.Button btn_alterContract;
        private System.Windows.Forms.Button btn_refreshDGV;
    }
}