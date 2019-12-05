namespace danielCherrin_CarRentalApp
{
    partial class frm_VehicleDGV
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
            this.dgv_Vehicles = new System.Windows.Forms.DataGridView();
            this.btn_alterVehicle = new System.Windows.Forms.Button();
            this.btn_refreshDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Vehicles
            // 
            this.dgv_Vehicles.AllowUserToAddRows = false;
            this.dgv_Vehicles.AllowUserToDeleteRows = false;
            this.dgv_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vehicles.Location = new System.Drawing.Point(19, 20);
            this.dgv_Vehicles.Name = "dgv_Vehicles";
            this.dgv_Vehicles.ReadOnly = true;
            this.dgv_Vehicles.Size = new System.Drawing.Size(1187, 561);
            this.dgv_Vehicles.TabIndex = 0;
            this.dgv_Vehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vehicles_CellClick);
            // 
            // btn_alterVehicle
            // 
            this.btn_alterVehicle.Enabled = false;
            this.btn_alterVehicle.Location = new System.Drawing.Point(1225, 20);
            this.btn_alterVehicle.Name = "btn_alterVehicle";
            this.btn_alterVehicle.Size = new System.Drawing.Size(160, 84);
            this.btn_alterVehicle.TabIndex = 1;
            this.btn_alterVehicle.Text = "Alter Vehicle";
            this.btn_alterVehicle.UseVisualStyleBackColor = true;
            this.btn_alterVehicle.Click += new System.EventHandler(this.btn_alterVehicle_Click);
            // 
            // btn_refreshDGV
            // 
            this.btn_refreshDGV.Location = new System.Drawing.Point(1225, 110);
            this.btn_refreshDGV.Name = "btn_refreshDGV";
            this.btn_refreshDGV.Size = new System.Drawing.Size(160, 84);
            this.btn_refreshDGV.TabIndex = 4;
            this.btn_refreshDGV.Text = "Refresh DGV";
            this.btn_refreshDGV.UseVisualStyleBackColor = true;
            this.btn_refreshDGV.Click += new System.EventHandler(this.btn_refreshDGV_Click);
            // 
            // frm_VehicleDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 600);
            this.Controls.Add(this.btn_refreshDGV);
            this.Controls.Add(this.btn_alterVehicle);
            this.Controls.Add(this.dgv_Vehicles);
            this.Name = "frm_VehicleDGV";
            this.Text = "Vehicle DGV";
            this.Load += new System.EventHandler(this.frm_VehicleDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Vehicles;
        private System.Windows.Forms.Button btn_alterVehicle;
        private System.Windows.Forms.Button btn_refreshDGV;
    }
}