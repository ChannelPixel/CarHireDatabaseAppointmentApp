using System;
using danielCherrin_CarRentalApp02;
using daneilCherrin_CarRentalApp02;
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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        bool dgv_HomeIsContracts = true;
        bool dgv_HomeIsVehicles = false;
        bool dgv_HomeIsCustomers = false;

        private void frm_Home_Load(object sender, EventArgs e)
        {
            dtp_SearchContractsDate.CustomFormat = "yyyy-MM-dd";
            dtp_SearchVehiclesFrom.CustomFormat = "yyyy-MM-dd";
            dtp_SearchVehiclesTo.CustomFormat = "yyyy-MM-dd";

            string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
            //string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con = new SqlConnection(str_connection);
            string MySelect = "SELECT " +
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
                                "JOIN[Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                              "WHERE [pickupDate]  = CAST('" + dtp_SearchContractsDate.Text + "' AS DATE) " +
                                "OR [returnDate] = CAST('" + dtp_SearchContractsDate.Text + "' AS DATE) ";


            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dgv_Home.ReadOnly = true;
            dgv_Home.DataSource = ds.Tables[0];
        }

        private void btn_SearchContracts_Click(object sender, EventArgs e)
        {
            string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
            //string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con = new SqlConnection(str_connection);
            string MySelect = "";

            if(!rbtn_SearchContractsLicenseNo.Checked && !rbtn_SearchContractsLastName.Checked)
            {
                MySelect = "SELECT " +
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
                                "JOIN[Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                           "WHERE " +
                                "pickupDate > CAST('" + dtp_SearchContractsDate.Text + "' AS DATE);";
            }
            else if(rbtn_SearchContractsLicenseNo.Checked && !rbtn_SearchContractsLastName.Checked)
            {
                if (string.IsNullOrEmpty(txt_SearchContractsLicenseNo.Text)|| string.IsNullOrWhiteSpace(txt_SearchContractsLicenseNo.Text))
                {
                    txt_SearchContractsLicenseNo.Text = "0000000";
                }
                MySelect = "SELECT " +
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
                                "JOIN[Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                           "WHERE " +
                                "pickupDate > CAST('" + dtp_SearchContractsDate.Text + "' AS DATE) AND driverLicenseNo = " + txt_SearchContractsLicenseNo.Text + ";";
            }
            else if(!rbtn_SearchContractsLicenseNo.Checked && rbtn_SearchContractsLastName.Checked)
            {
                MySelect = "SELECT " +
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
                                "JOIN[Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                           "WHERE " +
                                "pickupDate > CAST('" + dtp_SearchContractsDate.Text + "' AS DATE) AND lastName LIKE '%"+txt_SearchContractsLastName.Text+"%';";
            }
            

            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dgv_Home.DataSource = ds.Tables[0];
        }


        private void btn_CreateContractFrm_Click(object sender, EventArgs e)
        {
            Form frm_CreateContract = new frm_CreateContract();
            frm_CreateContract.ShowDialog();
        }

        private void dgv_Home_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgv_Home.CurrentCell.RowIndex;
            int currentColumn = dgv_Home.CurrentCell.ColumnIndex;
            dgv_Home.CurrentCell = dgv_Home.Rows[currentRow].Cells[currentColumn];

            if (dgv_HomeIsContracts)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Home.Rows[e.RowIndex];
                    txt_AlterContractContractNo.Text = row.Cells[0].Value.ToString();
                    btn_AlterContractFrm.Enabled = true;
                }
            }
            else if (dgv_HomeIsVehicles)
            {
                if (e.RowIndex >= 0)
                {

                }
            }
            else if (dgv_HomeIsCustomers)
            {
                if (e.RowIndex >= 0)
                {

                }
            }
        }


        private void btn_AlterContractFrm_Click(object sender, EventArgs e)
        {
            if (dgv_HomeIsContracts)
            {
                string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
                //string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
                SqlConnection con = new SqlConnection(str_connection);

                string MySelect = "SELECT * " +
                                  "FROM [CarRental].[dbo].[Contracts] " +
                                  "WHERE contractNo = " + txt_AlterContractContractNo.Text;

                SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ada.Fill(ds,"Contracts");
                dt = ds.Tables["Contracts"];

                string a = dt.Rows[0]["contractNo"].ToString();
                string b = dt.Rows[0]["empNo"].ToString(); ;
                string c = dt.Rows[0]["customerNo"].ToString(); ;
                string d = dt.Rows[0]["VIN"].ToString(); ;
                string ee = dt.Rows[0]["pickupDate"].ToString(); ;
                string f = dt.Rows[0]["pickupTime"].ToString(); ;
                string g = dt.Rows[0]["returnDate"].ToString(); ;
                string h = dt.Rows[0]["returnTime"].ToString(); ;
                string i = dt.Rows[0]["discount"].ToString(); ;
                string j = dt.Rows[0]["cost"].ToString(); ;
                string k = dt.Rows[0]["odoReadingOutbound"].ToString(); ;
                string l = dt.Rows[0]["odoReadingInbound"].ToString(); ;
                string m = dt.Rows[0]["observationsOut"].ToString(); ;
                string n = dt.Rows[0]["observationsIn"].ToString(); ;

                Form frm_AlterContract = new frm_AlterContract(a,b,c,d,ee,f,g,h,i,j,k,l,m,n);
                frm_AlterContract.ShowDialog();
            }
        }

        private void btn_SearchContractsToday_Click(object sender, EventArgs e)
        {
            rbtn_SearchContractsLastName.Checked = false;
            rbtn_SearchContractsLicenseNo.Checked = false;
            txt_SearchContractsLastName.Clear();
            txt_SearchContractsLicenseNo.Clear();
            dtp_SearchContractsDate.ResetText();

            string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
            //string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con = new SqlConnection(str_connection);
            string MySelect = "SELECT " +
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
                                "JOIN[Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN " +

                              "WHERE [pickupDate]  = CAST('" + dtp_SearchContractsDate.Text + "' AS DATE) " +
                                "OR [returnDate] = CAST('" + dtp_SearchContractsDate.Text + "' AS DATE) ";

            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);

            dgv_Home.DataSource = ds.Tables[0];

            dgv_HomeIsContracts = true;
            dgv_HomeIsVehicles = false;
            dgv_HomeIsCustomers = false;


        }

        private void btn_SearchContractsFull_Click(object sender, EventArgs e)
        {
            rbtn_SearchContractsLastName.Checked = false;
            rbtn_SearchContractsLicenseNo.Checked = false;
            txt_SearchContractsLastName.Clear();
            txt_SearchContractsLicenseNo.Clear();
            dtp_SearchContractsDate.ResetText();

            string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
            //string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con = new SqlConnection(str_connection);
            string MySelect = "SELECT " +
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
                                "JOIN[Customers] ON[Contracts].customerNo = Customers.customerNo " +
                                "JOIN Vehicles ON Vehicles.VIN = Contracts.VIN ";

            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dgv_Home.DataSource = ds.Tables[0];

            dgv_HomeIsContracts = true;
            dgv_HomeIsVehicles = false;
            dgv_HomeIsCustomers = false;
        }

        private void rbtn_SearchContractsLicenseNo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_SearchContractsLicenseNo.Checked)
            {
                txt_SearchContractsLicenseNo.ReadOnly = false;
                txt_SearchContractsLastName.ReadOnly = true;
            }
        }

        private void rbtn_SearchContractsLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_SearchContractsLastName.Checked)
            {
                txt_SearchContractsLicenseNo.ReadOnly = true;
                txt_SearchContractsLastName.ReadOnly = false;
            }
        }
    }
}
