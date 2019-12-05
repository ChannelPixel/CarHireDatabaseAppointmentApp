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
    public partial class frm_CreateContract : Form
    {
        public frm_CreateContract()
        {
            InitializeComponent();
            dtp_PickupDate.CustomFormat = "yyyy-MM-dd"; ;
            dtp_PickupTime.CustomFormat = "hh:mm:ss tt"; ;
            dtp_ReturnDate.CustomFormat = "yyyy-MM-dd"; ;
            dtp_ReturnTime.CustomFormat = "hh:mm:ss tt"; ;
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_registerNewContract_Click(object sender, EventArgs e)
        {
            //string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
            string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con = new SqlConnection(str_connection);

                string myUpd = "INSERT INTO[dbo].[Contracts] " +
                                "([empNo] " +
                                ",[customerNo] " +
                                ",[VIN] " +
                                ",[pickupDate] " +
                                ",[pickupTime] " +
                                ",[returnDate] " +
                                ",[returnTime] " +
                                ",[discount] " +
                                ",[cost] " +
                                ",[odoReadingOutbound] " +
                                ",[odoReadingInbound] " +
                                ",[observationsOut] " +
                                ",[observationsIn]) " +
                        " VALUES " +
                                "(" + txt_EmpNo.Text + " " +
                                "," + txt_CustomerNo.Text + " " +
                                ",'" + txt_VIN.Text + "' " +
                                ",CAST('" + dtp_PickupDate.Text + "' AS DATE) " +
                                ",CAST('" + dtp_PickupTime.Text + "' AS TIME(7)) " +
                                ",CAST('" + dtp_ReturnDate.Text + "' AS DATE) " +
                                ",CAST('" + dtp_ReturnTime.Text + "' AS TIME(7)) " +
                                "," + txt_Discount.Text + " " +
                                "," + txt_Cost.Text + " " +
                                "," + txt_OdoOutbound.Text + " " +
                                "," + txt_OdoInbound.Text + " " +
                                ",'" + txt_ObOut.Text + "' " +
                                ",'" + txt_ObIn.Text + "')";
 
  
            con.Open();
            SqlCommand custUpd = new SqlCommand(myUpd, con);
            custUpd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Contract was successfully added!");
        }
    }
}
