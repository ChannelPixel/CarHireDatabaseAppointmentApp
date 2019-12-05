using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace danielCherrin_CarRentalApp
{
    public partial class frm_VehicleDGV : Form
    {
        Vehicle DGVVehicle = new Vehicle();

        public frm_VehicleDGV()
        {
            InitializeComponent();
        }

        private void frm_VehicleDGV_Load(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                        "* " +

                                     "FROM [CarRental].[dbo].[Vehicles];";

            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Vehicles.DataSource = ds.Tables[0];
        }

        private void btn_alterVehicle_Click(object sender, EventArgs e)
        {
            frm_AlterVehicle newAlterVehicle = new frm_AlterVehicle(DGVVehicle);
            newAlterVehicle.Show();
        }

        private void dgv_Vehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgv_Vehicles.CurrentCell.RowIndex;
            int currentColumn = dgv_Vehicles.CurrentCell.ColumnIndex;
            dgv_Vehicles.CurrentCell = dgv_Vehicles.Rows[currentRow].Cells[currentColumn];

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Vehicles.Rows[e.RowIndex];

                string str_QuerySelect = "SELECT " +
                                        "* " +

                                        "FROM [CarRental].[dbo].[Vehicles] " +

                                        "WHERE " +
                                            "VIN = " + row.Cells[0].Value.ToString() + ";";

                SqlConnection con = new SqlConnection(connectionStr.conn);
                SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                ada.Fill(ds, "Vehicles");
                dt = ds.Tables["Vehicles"];

                DGVVehicle.VIN = dt.Rows[0][0].ToString();
                DGVVehicle.manufacturer = dt.Rows[0][1].ToString();
                DGVVehicle.model = dt.Rows[0][2].ToString();
                DGVVehicle.colour = dt.Rows[0][3].ToString();
                DGVVehicle.bodyType = dt.Rows[0][4].ToString();
                DGVVehicle.odoCurrent = int.Parse(dt.Rows[0][5].ToString());
                DGVVehicle.regoNo = dt.Rows[0][6].ToString();
                DGVVehicle.regoExp = dt.Rows[0][7].ToString();
                DGVVehicle.dailyRate = double.Parse(dt.Rows[0][8].ToString());
                DGVVehicle.hourlyRate = double.Parse(dt.Rows[0][9].ToString());
                DGVVehicle.observations = dt.Rows[0][10].ToString();
                DGVVehicle.yearOfManuf = int.Parse(dt.Rows[0][11].ToString());

                btn_alterVehicle.Enabled = true;
            }
        }

        private void btn_refreshDGV_Click(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                        "* " +

                                     "FROM [CarRental].[dbo].[Vehicles];";

            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Vehicles.DataSource = ds.Tables[0];
        }
    }
}
