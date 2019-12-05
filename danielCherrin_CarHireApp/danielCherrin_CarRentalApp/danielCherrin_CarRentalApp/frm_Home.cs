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
    /*NOTES:
     * A DataSet Object is C#'s version of a Database Obj
     * A DataTable Object is C#'s version of a Table Obj
    */

    public partial class frm_Home : Form
    {
        Contract currAppointment = new Contract();

        public frm_Home()
        {
            InitializeComponent();
            dtp_contractsSearchFrom.CustomFormat = "yyyy-MM-dd";
        }

        
        private void frm_Home_Load(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                            "Contracts.contractNo " +
                                            ",Contracts.empNo " +
                                            ",Contracts.customerNo " +
                                            ",pickupDate " +
                                            ",pickupTime " +
                                            ",returnDate " +
                                            ",returnTime " +
                                            ",firstName " +
                                            ",lastName " +
                                            ",driverLicenseNo " +
                                            ",Vehicles.VIN " +
                                            ",manufacturer " +
                                            ",model " +
                                            ",colour " +
                                            ",bodyType " +


                                     "FROM [CarRental].[dbo].[Contracts] " +
                                            "JOIN [Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                            "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                                     "WHERE " +
                                            "pickupDate = CAST('" + dtp_contractsSearchFrom.Text + "' AS DATE) " +
                                            "OR " +
                                            "returnDate = CAST('" + dtp_contractsSearchFrom.Text + "' AS DATE);";


            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Home.DataSource = ds.Tables[0];
        }

        private void btn_createCustomer_Click(object sender, EventArgs e)
        {
            frm_CreateCustomer frm_NewCustomer = new frm_CreateCustomer();
            frm_NewCustomer.Show();
        }

        private void btn_createVehicle_Click(object sender, EventArgs e)
        {
            frm_CreateVehicle frm_NewVehicle = new frm_CreateVehicle();
            frm_NewVehicle.Show();
        }

        private void btn_createContract_Click(object sender, EventArgs e)
        {
            frm_CreateContract frm_NewContract = new frm_CreateContract();
            frm_NewContract.Show();
        }

        private void btn_searchContracts_Click(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                            "Contracts.contractNo " +
                                            ",Contracts.empNo " +
                                            ",Contracts.customerNo " +
                                            ",pickupDate " +
                                            ",pickupTime " +
                                            ",returnDate " +
                                            ",returnTime " +
                                            ",firstName " +
                                            ",lastName " +
                                            ",driverLicenseNo " +
                                            ",Vehicles.VIN " +
                                            ",manufacturer " +
                                            ",model " +
                                            ",colour " +
                                            ",bodyType " +


                                     "FROM [CarRental].[dbo].[Contracts] " +
                                            "JOIN [Customers] ON [Contracts].customerNo = Customers.customerNo " +
                                            "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                                     "WHERE " +
                                            "pickupDate >= CAST('" + dtp_contractsSearchFrom.Text + "' AS DATE) " +
                                            "OR " +
                                            "returnDate >= CAST('" + dtp_contractsSearchFrom.Text + "' AS DATE);";


            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Home.DataSource = ds.Tables[0];
        }

        private void dgv_Home_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgv_Home.CurrentCell.RowIndex;
            int currentColumn = dgv_Home.CurrentCell.ColumnIndex;
            dgv_Home.CurrentCell = dgv_Home.Rows[currentRow].Cells[currentColumn];

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Home.Rows[e.RowIndex];

                string str_QuerySelect = "SELECT " +
                                        "* " +

                                        "FROM [CarRental].[dbo].[Contracts] " +

                                        "WHERE " +
                                            "contractNo = " + row.Cells["contractNo"].Value.ToString() + ";";


                SqlConnection con = new SqlConnection(connectionStr.conn);
                SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                ada.Fill(ds, "Contracts");
                dt = ds.Tables["Contracts"];


                currAppointment.contractNo = int.Parse(dt.Rows[0][0].ToString());
                currAppointment.empNo = int.Parse(dt.Rows[0][1].ToString());
                currAppointment.customerNo = int.Parse(dt.Rows[0][2].ToString());
                currAppointment.VIN = dt.Rows[0][3].ToString();
                currAppointment.pickupDate = dt.Rows[0][4].ToString();
                currAppointment.pickupTime = dt.Rows[0][5].ToString();
                currAppointment.returnDate = dt.Rows[0][6].ToString();
                currAppointment.returnTime = dt.Rows[0][7].ToString();

                if (!string.IsNullOrWhiteSpace(dt.Rows[0][8].ToString()))
                {
                    currAppointment.discount = float.Parse(dt.Rows[0][8].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][9].ToString()))
                {
                    currAppointment.cost = double.Parse(dt.Rows[0][9].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][10].ToString()))
                {
                    currAppointment.odoReadingOutbound = int.Parse(dt.Rows[0][10].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][11].ToString()))
                {
                    currAppointment.odoReadingInbound = int.Parse(dt.Rows[0][11].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][12].ToString()))
                {
                    currAppointment.observationsOut = dt.Rows[0][12].ToString();
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][13].ToString()))
                {
                    currAppointment.observationsOut = dt.Rows[0][13].ToString();
                }
                btn_alterAppointment.Enabled = true;
            }
        }

        private void btn_contractDGV_Click(object sender, EventArgs e)
        {
            frm_ContractDGV frm_NewContractDGV = new frm_ContractDGV();
            frm_NewContractDGV.Show();
        }

        private void btn_customerDGV_Click(object sender, EventArgs e)
        {
            frm_CustomerDGV frm_NewCustomerDGV = new frm_CustomerDGV();
            frm_NewCustomerDGV.Show();
        }

        private void btn_vehicleDGV_Click(object sender, EventArgs e)
        {
            frm_VehicleDGV frm_NewVehicleDGV = new frm_VehicleDGV();
            frm_NewVehicleDGV.Show();
        }

        private void btn_alterAppointment_Click(object sender, EventArgs e)
        {
            frm_AlterContract frm_newAlterContract = new frm_AlterContract(currAppointment);
            frm_newAlterContract.Show();
        }
    }

    public static class connectionStr
    {
        //public static string conn = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
        public static string conn = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
    }
}
