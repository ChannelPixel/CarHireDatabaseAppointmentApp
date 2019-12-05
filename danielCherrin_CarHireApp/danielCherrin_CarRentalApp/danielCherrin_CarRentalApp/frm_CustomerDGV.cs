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
using System.Text.RegularExpressions;

namespace danielCherrin_CarRentalApp
{
    public partial class frm_CustomerDGV : Form
    {

        Customer DGVCustomer = new Customer();

        public frm_CustomerDGV()
        {
            InitializeComponent();
        }

        private void frm_CustomerDGV_Load(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                        "* " +

                                     "FROM [CarRental].[dbo].[Customers];";

            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Customers.DataSource = ds.Tables[0];
        }

        private void btn_alterCustomer_Click(object sender, EventArgs e)
        {
            frm_AlterCustomer newAlterCustomer = new frm_AlterCustomer(DGVCustomer);
            newAlterCustomer.Show();
        }

        private void dgv_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgv_Customers.CurrentCell.RowIndex;
            int currentColumn = dgv_Customers.CurrentCell.ColumnIndex;
            dgv_Customers.CurrentCell = dgv_Customers.Rows[currentRow].Cells[currentColumn];

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Customers.Rows[e.RowIndex];

                string str_QuerySelect = "SELECT " +
                                        "* " +

                                        "FROM [CarRental].[dbo].[Customers] " +

                                        "WHERE " +
                                            "customerNo = " + row.Cells[0].Value.ToString() + ";";


                SqlConnection con = new SqlConnection(connectionStr.conn);
                SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                ada.Fill(ds, "Customers");
                dt = ds.Tables["Customers"];

                DGVCustomer.customerNo = int.Parse(dt.Rows[0][0].ToString());
                DGVCustomer.firstName = dt.Rows[0][1].ToString();
                DGVCustomer.lastName = dt.Rows[0][2].ToString();
                DGVCustomer.streetNo = int.Parse(dt.Rows[0][3].ToString());
                DGVCustomer.streetName = dt.Rows[0][4].ToString();
                DGVCustomer.streetPostcode = int.Parse(dt.Rows[0][5].ToString());
                DGVCustomer.residencySuburb = dt.Rows[0][6].ToString();
                DGVCustomer.residencyState = dt.Rows[0][7].ToString().Trim();
                DGVCustomer.mobPhone = int.Parse(dt.Rows[0][8].ToString());
                DGVCustomer.creditCardNo = int.Parse(dt.Rows[0][9].ToString());
                DGVCustomer.creditCardName = dt.Rows[0][10].ToString();
                DGVCustomer.creditCardType = dt.Rows[0][11].ToString();
                DGVCustomer.creditCardExp = dt.Rows[0][12].ToString();
                DGVCustomer.driverLicenseNo = int.Parse(dt.Rows[0][13].ToString());

                btn_alterCustomer.Enabled = true;
            }
        }

        private void btn_refreshDGV_Click(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                        "* " +

                                     "FROM [CarRental].[dbo].[Customers];";

            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Customers.DataSource = ds.Tables[0];
        }
    }
}
