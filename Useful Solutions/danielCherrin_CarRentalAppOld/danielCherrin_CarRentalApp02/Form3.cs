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

namespace daneilCherrin_CarRentalApp02
{
    public partial class frm_AlterContract : Form
    {
        string contractNo;
        string empNo;
        string customerNo;
        string VIN;
        string pickupDate;
        string pickupTime;
        string returnDate;
        string returnTime;
        string discount;
        string cost;
        string odoReadingOutbound;
        string odoReadingInbound;
        string observationsOut;
        string observationsIn;

        public frm_AlterContract(string a, string b, string c, string d, string e,
                        string f, string g, string h, string i,
                        string j, string k, string l, string m, string n)
        {
            contractNo = a;
            empNo = b;
            customerNo = c;
            VIN = d;
            pickupDate = e;
            pickupTime = f;
            returnDate = g;
            returnTime = h;
            discount = i;
            cost = j;
            odoReadingOutbound = k;
            odoReadingInbound = l;
            observationsOut = m;
            observationsIn = n;
            InitializeComponent();
            dtp_PickupDate.CustomFormat = "yyyy-MM-dd"; ;
            dtp_PickupTime.CustomFormat = "hh:mm:ss tt"; ;
            dtp_ReturnDate.CustomFormat = "yyyy-MM-dd"; ;
            dtp_ReturnTime.CustomFormat = "hh:mm:ss tt"; ;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_ContractNo.Text = contractNo;
            txt_EmpNo.Text = empNo;
            txt_CustomerNo.Text = customerNo;
            txt_VIN.Text = VIN;
            dtp_PickupDate.Value = DateTime.Parse(pickupDate);
            dtp_PickupTime.Value = DateTime.Parse(pickupTime);
            dtp_ReturnDate.Value = DateTime.Parse(returnDate);
            dtp_ReturnTime.Value = DateTime.Parse(returnTime);
            txt_Discount.Text = discount;
            txt_Cost.Text = cost;
            txt_OdoOutbound.Text = odoReadingOutbound;
            txt_OdoInbound.Text = odoReadingInbound;
            txt_ObOut.Text = observationsOut;
            txt_ObIn.Text = observationsIn;

            if(String.IsNullOrWhiteSpace(txt_Discount.Text))
            {
                txt_Discount.Text = "NULL";
            }
            if (String.IsNullOrWhiteSpace(txt_Cost.Text))
            {
                txt_Cost.Text = "NULL";
            }
            if (String.IsNullOrWhiteSpace(txt_OdoOutbound.Text))
            {
                txt_OdoOutbound.Text = "NULL";
            }
            if (String.IsNullOrWhiteSpace(txt_OdoInbound.Text))
            {
                txt_OdoInbound.Text = "NULL";
            }
            if (String.IsNullOrWhiteSpace(txt_ObOut.Text))
            {
                txt_ObOut.Text = "NULL";
            }
            if (String.IsNullOrWhiteSpace(txt_ObIn.Text))
            {
                txt_ObIn.Text = "NULL";
            }
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_alterContract_Click(object sender, EventArgs e)
        {
            string str_connection = "Data Source = ZEO-PC; Initial Catalog = CarRental; Integrated Security = True";
            //string str_connection = "Data Source = MSSQL002; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con = new SqlConnection(str_connection);

            string myUpd = "UPDATE " +
                           "[dbo].[Contracts] " +

                           "SET" +
                           "[empNo] = "+txt_EmpNo.Text+" " +
                           ",[customerNo] = " + txt_CustomerNo.Text + " " +
                           ",[VIN] = '" + txt_VIN.Text + "' " +
                           ",[pickupDate] = CAST( '" + dtp_PickupDate.Text + "' AS DATE) " +
                           ",[pickupTime] = CAST( '" + dtp_PickupTime.Text + "' AS TIME(7)) " +
                           ",[returnDate] = CAST( '" + dtp_ReturnDate.Text + "' AS DATE) " +
                           ",[returnTime] = CAST( '" + dtp_PickupDate.Text + "' AS TIME(7)) " +
                           ",[discount] = " + txt_Discount.Text + " " +
                           ",[cost] = " + txt_Cost.Text + " " +
                           ",[odoReadingOutbound] = " + txt_OdoOutbound.Text + " " +
                           ",[odoReadingInbound] = " + txt_OdoInbound.Text + " " +
                           ",[observationsOut] = '" + txt_ObOut.Text + "' " +
                           ",[observationsIn] = '" + txt_ObIn.Text + "' " +
                            
                           "WHERE " +
                           "contractNo = " +txt_ContractNo.Text+ " ;";


            con.Open();
            SqlCommand custUpd = new SqlCommand(myUpd, con);
            custUpd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Contract was successfully altered!");
        }
    }
}
