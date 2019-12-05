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
        Contract contractObj = new Contract();

        public frm_CreateContract()
        {
            InitializeComponent();
            dtp_PickupDate.CustomFormat = "yyyy-MM-dd";
            dtp_PickupTime.CustomFormat = "HH:mm";
            dtp_ReturnDate.CustomFormat = "yyyy-MM-dd";
            dtp_ReturnTime.CustomFormat = "HH:mm";
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_registerNewContract_Click(object sender, EventArgs e)
        {
            if(verifyContract())
            {
                string str_QuerySelect =
                    "SELECT CASE WHEN EXISTS " +
                    "( "+
                        "SELECT * "+
                        "FROM " +
                        "[Contracts] " +
                        "WHERE "+
                        "Contracts.VIN = '"+contractObj.VIN+"' "+
                        "AND(pickupDate BETWEEN CAST('"+contractObj.pickupDate+ "' AS date) AND CAST('" + contractObj.returnDate + "' AS date) " +
                        "OR returnDate BETWEEN CAST('" + contractObj.pickupDate + "' AS date) AND CAST('" + contractObj.returnDate + "' AS date) " +
                        "OR((pickupDate < CAST('" + contractObj.pickupDate + "' AS date) AND pickupDate < CAST('" + contractObj.returnDate + "' AS date)) " +
                        "    AND(returnDate > CAST('" + contractObj.pickupDate + "' AS date) AND returnDate > CAST('" + contractObj.returnDate + "' AS date)))) " +
                    ") "+
                    "THEN CAST(1 AS BIT) "+
                    "ELSE CAST(0 AS BIT) END;";

                SqlConnection cona = new SqlConnection(connectionStr.conn);
                SqlDataAdapter adaa = new SqlDataAdapter(str_QuerySelect, cona);
                DataSet dsa = new DataSet();
                DataTable dta = new DataTable();

                adaa.Fill(dsa, "Contracts");
                dta = dsa.Tables["Contracts"];

                if (!Convert.ToBoolean(dta.Rows[0][0].ToString()))
                {
                    string str_getRates = "SELECT dailyRate, hourlyRate " +
                                          "FROM[Vehicles] " +
                                          "WHERE VIN = " + contractObj.VIN + ";";
                    
                    SqlConnection conb = new SqlConnection(connectionStr.conn);
                    SqlDataAdapter adab = new SqlDataAdapter(str_getRates,conb);
                    DataSet dsb = new DataSet();
                    DataTable dtb = new DataTable();
                    adab.Fill(dsb, "Vehicles");
                    dtb = dsb.Tables["Vehicles"];

                    double dbl_dailyRate = double.Parse(dtb.Rows[0][0].ToString());
                    double dbl_hourlyRate = double.Parse(dtb.Rows[0][1].ToString());

                    DateTime dt_pickup = Convert.ToDateTime(contractObj.pickupDate + " " + contractObj.pickupTime);
                    DateTime dt_return = Convert.ToDateTime(contractObj.returnDate + " " + contractObj.returnTime);
                    TimeSpan ts_difference = dt_return.Subtract(dt_pickup);

                    if (contractObj.discount == 0)
                    {
                        contractObj.cost = (ts_difference.Days * dbl_dailyRate) + (ts_difference.Hours * dbl_hourlyRate);
                    }
                    else
                    {
                        contractObj.cost = (((ts_difference.Days * dbl_dailyRate) + (ts_difference.Hours * dbl_hourlyRate)) * (1 - contractObj.discount));
                    }

                    string stringyBoi = "The information you have provided is :\n";
                    stringyBoi += "\nEmpNo - " + contractObj.empNo;
                    stringyBoi += "\nCustomerNo - " + contractObj.customerNo;
                    stringyBoi += "\nVIN - " + contractObj.VIN;
                    stringyBoi += "\nPickup Date - " + contractObj.pickupDate;
                    stringyBoi += "\nPickup Time - " + contractObj.pickupTime;
                    stringyBoi += "\nReturn Date - " + contractObj.returnDate;
                    stringyBoi += "\nReturn Time - " + contractObj.returnTime;
                    stringyBoi += "\nDiscount - " + ((contractObj.discount*100).ToString()+"%");
                    stringyBoi += "\nCost - $" + contractObj.cost;
                    stringyBoi += "\nodoReading Outbound - " + contractObj.odoReadingOutbound;
                    stringyBoi += "\nodoReading Inbound - " + contractObj.odoReadingInbound;
                    stringyBoi += "\n\nobservations Out - " + contractObj.observationsOut;
                    stringyBoi += "\n\nobservations In - " + contractObj.observationsIn;

                    DialogResult result;
                    result = MessageBox.Show(stringyBoi, "Contract Obj Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == System.Windows.Forms.DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection(connectionStr.conn);

                        string myInsert = "INSERT INTO[dbo].[Contracts] " +
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
                                                    ",[observationsIn])" +
                                          " VALUES  " +
                                                    "(" + contractObj.empNo + " " +
                                                    "," + contractObj.customerNo + " " +
                                                    ",'" + contractObj.VIN + "' " +
                                                    ",CAST('" + contractObj.pickupDate + "' AS DATE) " +
                                                    ",CAST('" + contractObj.pickupTime + "' AS TIME) " +
                                                    ",CAST('" + contractObj.returnDate + "' AS DATE) " +
                                                    ",CAST('" + contractObj.returnTime + "' AS TIME) " +
                                                    "," + contractObj.discount + " " +
                                                    "," + contractObj.cost + " " +
                                                    "," + contractObj.odoReadingOutbound + " " +
                                                    "," + contractObj.odoReadingInbound + " " +
                                                    ",'" + contractObj.observationsOut + "' " +
                                                    ",'" + contractObj.observationsIn + "'); ";

                        con.Open();
                        SqlCommand contInsert = new SqlCommand(myInsert,con);
                        contInsert.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Contract successfully added into database.");
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("The dates supplied for the requested VIN conflict with another contract's date.\n"+
                                    "Open the the Contract DGV to compare dates.\n"+
                                    "Please change the supplied dates or vehicle VIN");
                }
            }
        }

        public bool verifyString(TextBox textboxS, string label)
        {
            if (string.IsNullOrWhiteSpace(textboxS.Text))
            {
                MessageBox.Show("ERROR: Input in '" + label + "' is null, empty or whitespace\n" +
                                "Please enter a valid '" + label + "'.");
                textboxS.Clear();
                textboxS.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool verifyContract()
        {
            DateTime a = dtp_PickupDate.Value.Add((TimeSpan.Parse(dtp_PickupTime.Text)));
            DateTime b = dtp_ReturnDate.Value.Add((TimeSpan.Parse(dtp_ReturnTime.Text)));

            if (!verifyString(txt_VIN, "VIN"))
            {
                return false;
            }
            else if (!int.TryParse(txt_EmpNo.Text, out contractObj.empNo) || string.IsNullOrWhiteSpace(txt_EmpNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Emp No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Emp No'.");
                txt_EmpNo.Clear();
                txt_EmpNo.Focus();
                return false;
            }
            else if (!int.TryParse(txt_CustomerNo.Text, out contractObj.customerNo) || string.IsNullOrWhiteSpace(txt_CustomerNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Customer No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Customer No'.");
                txt_CustomerNo.Clear();
                txt_CustomerNo.Focus();
                return false;
            }
            else if (DateTime.Compare(a, b) > 0)
            {
                MessageBox.Show("ERROR: The pickup date and time is later than the return date.\n" +
                                "Revise pickup date and time so that it is earlier than return date and time.");
                dtp_PickupDate.Focus();
                return false;
            }
            else
            {
                contractObj.VIN = txt_VIN.Text;
                contractObj.pickupDate = dtp_PickupDate.Text;
                contractObj.pickupTime = dtp_PickupTime.Text;
                contractObj.returnDate = dtp_ReturnDate.Text;
                contractObj.returnTime = dtp_ReturnTime.Text;

                if(!string.IsNullOrWhiteSpace(txt_Discount.Text))
                {
                    if (!float.TryParse(txt_Discount.Text, out contractObj.discount))
                    {
                        MessageBox.Show("ERROR: Input in 'Discount' isn't a number.\n" +
                                        "Please enter a valid 'Discount'.");
                        txt_Discount.Clear();
                        txt_Discount.Focus();
                        return false;
                    }
                    else if(contractObj.discount >= 1)
                    {
                        MessageBox.Show("ERROR: Input in 'Discount is larger or equal to 1.\n" +
                                        "Please enter a 'Discount' number smaller than 0.\n" +
                                        "Eg. 0.7 is 70% off");
                        txt_Discount.Clear();
                        txt_Discount.Focus();
                        return false;
                    }
                }
                if (!string.IsNullOrWhiteSpace(txt_OdoOutbound.Text))
                {
                    if (!int.TryParse(txt_OdoOutbound.Text, out contractObj.odoReadingOutbound))
                    {
                        MessageBox.Show("ERROR: Input in 'Odo Reading Outbound' isn't a number.\n" +
                                        "Please enter a valid 'Odo Reading Outbound'.");
                        txt_OdoOutbound.Clear();
                        txt_OdoOutbound.Focus();
                        return false;
                    }
                    else
                    {
                        
                    }
                }
                if (!string.IsNullOrWhiteSpace(txt_OdoInbound.Text))
                {
                    if (!int.TryParse(txt_OdoInbound.Text, out contractObj.odoReadingInbound))
                    {
                        MessageBox.Show("ERROR: Input in 'Odo Reading Inbound' isn't a number.\n" +
                                        "Please enter a valid 'Odo Reading Inbound'.");
                        txt_OdoInbound.Clear();
                        txt_OdoInbound.Focus();
                        return false;
                    }
                }
                if (!string.IsNullOrWhiteSpace(txt_ObOut.Text))
                {
                    contractObj.observationsOut = txt_ObOut.Text;
                }
                if (!string.IsNullOrWhiteSpace(txt_ObIn.Text))
                {
                    contractObj.observationsIn = txt_ObIn.Text;
                }
                return true;
            }
        }
    }
}
