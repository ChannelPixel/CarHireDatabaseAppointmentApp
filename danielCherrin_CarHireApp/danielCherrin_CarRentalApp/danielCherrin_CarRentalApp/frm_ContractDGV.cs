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
    public partial class frm_ContractDGV : Form
    {
        Contract DGVContract = new Contract();

        public frm_ContractDGV()
        {
            InitializeComponent();
        }

        private void frm_ContractDGV_Load(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                        "* " +

                                     "FROM [CarRental].[dbo].[Contracts];";

            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Contracts.DataSource = ds.Tables[0];
        }

        private void btn_refreshDGV_Click(object sender, EventArgs e)
        {
            string str_QuerySelect = "SELECT " +
                                        "* " +

                                     "FROM [CarRental].[dbo].[Contracts];";

            SqlConnection con = new SqlConnection(connectionStr.conn);
            SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);

            DataSet ds = new DataSet();
            ada.Fill(ds);

            //Fills DGV with dataset(C# Database Object)'s
            dgv_Contracts.DataSource = ds.Tables[0];
        }

        private void btn_alterContract_Click(object sender, EventArgs e)
        {
            frm_AlterContract newAlterCustomer = new frm_AlterContract(DGVContract);
            newAlterCustomer.Show();
        }

        private void dgv_Contracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgv_Contracts.CurrentCell.RowIndex;
            int currentColumn = dgv_Contracts.CurrentCell.ColumnIndex;
            dgv_Contracts.CurrentCell = dgv_Contracts.Rows[currentRow].Cells[currentColumn];

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Contracts.Rows[e.RowIndex];

                string str_QuerySelect = "SELECT " +
                                        "* " +

                                        "FROM [CarRental].[dbo].[Contracts] " +

                                        "WHERE " +
                                            "contractNo = " + row.Cells[0].Value.ToString() + ";";


                SqlConnection con = new SqlConnection(connectionStr.conn);
                SqlDataAdapter ada = new SqlDataAdapter(str_QuerySelect, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                ada.Fill(ds, "Contracts");
                dt = ds.Tables["Contracts"];


                DGVContract.contractNo = int.Parse(dt.Rows[0][0].ToString());
                DGVContract.empNo = int.Parse(dt.Rows[0][1].ToString());
                DGVContract.customerNo = int.Parse(dt.Rows[0][2].ToString());
                DGVContract.VIN = dt.Rows[0][3].ToString();
                DGVContract.pickupDate = dt.Rows[0][4].ToString();
                DGVContract.pickupTime = dt.Rows[0][5].ToString();
                DGVContract.returnDate = dt.Rows[0][6].ToString();
                DGVContract.returnTime = dt.Rows[0][7].ToString();

                if (!string.IsNullOrWhiteSpace(dt.Rows[0][8].ToString()))
                {
                    DGVContract.discount = float.Parse(dt.Rows[0][8].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][9].ToString()))
                {
                    DGVContract.cost = double.Parse(dt.Rows[0][9].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][10].ToString()))
                {
                    DGVContract.odoReadingOutbound = int.Parse(dt.Rows[0][10].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][11].ToString()))
                {
                    DGVContract.odoReadingInbound = int.Parse(dt.Rows[0][11].ToString());
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][12].ToString()))
                {
                    DGVContract.observationsOut = dt.Rows[0][12].ToString();
                }
                if (!string.IsNullOrWhiteSpace(dt.Rows[0][13].ToString()))
                {
                    DGVContract.observationsOut = dt.Rows[0][13].ToString();
                }

                btn_alterContract.Enabled = true;
            }
        }
    }
}
