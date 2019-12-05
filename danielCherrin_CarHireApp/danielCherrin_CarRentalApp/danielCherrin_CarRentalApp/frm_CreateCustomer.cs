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
    public partial class frm_CreateCustomer : Form
    {

        Customer customerObj = new Customer();

        public frm_CreateCustomer()
        {
            InitializeComponent();
            dtp_creditCardExp.CustomFormat = "yyyy-MM-dd";
            cmbo_creditCardType.SelectedIndex = 0;
        }

        private void btn_CancelForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_confirmForm_Click(object sender, EventArgs e)
        {
            if (verifyCustomer())
            {
                string stringyBoi = "The information you have provided is: \n";
                stringyBoi += "\nFirst Name - " + customerObj.firstName;
                stringyBoi += "\nLast Name - " + customerObj.lastName;
                stringyBoi += "\nStreet No - " + customerObj.streetNo;
                stringyBoi += "\nStreet Name - " + customerObj.streetName;
                stringyBoi += "\nStreet PostCode - " + customerObj.streetPostcode;
                stringyBoi += "\nResidency Suburb - " + customerObj.residencySuburb;
                stringyBoi += "\nResidency State - " + customerObj.residencyState;
                stringyBoi += "\nMobile Phone - " + customerObj.mobPhone;
                stringyBoi += "\nCredit Card No - " + customerObj.creditCardNo;
                stringyBoi += "\nCredit Card Name - " + customerObj.creditCardName;
                stringyBoi += "\nCredit Card Type - " + customerObj.creditCardType;
                stringyBoi += "\nCredit Card Exp - " + customerObj.creditCardExp;
                stringyBoi += "\nDriver License No - " + customerObj.driverLicenseNo + "\n\n";
                stringyBoi += "Create customer using informatiom?";

                DialogResult result;
                result = MessageBox.Show(stringyBoi, "Customer Obj Information.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(connectionStr.conn);


                    string myInsert = "INSERT INTO[dbo].[Customers] " +
                                                   "([firstName] " +
                                                   ",[lastName] " +
                                                   ",[streetNo] " +
                                                   ",[streetName] " +
                                                   ",[streetPostcode] " +
                                                   ",[residencySuburb] " +
                                                   ",[residencyState] " +
                                                   ",[mobPhone] " +
                                                   ",[creditCardNo] " +
                                                   ",[creditCardName] " +
                                                   ",[creditCardType] " +
                                                   ",[creditCardExp] " +
                                                   ",[driverLicenseNo]) " +
                                             "VALUES " +
                                                   "('" + customerObj.firstName + "' " +
                                                   ",'" + customerObj.lastName + "' " +
                                                   "," + customerObj.streetNo + " " +
                                                   ",'" + customerObj.streetName + "' " +
                                                   "," + customerObj.streetPostcode + " " +
                                                   ",'" + customerObj.residencySuburb + "' " +
                                                   ",'" + customerObj.residencyState + "' " +
                                                   "," + customerObj.mobPhone + " " +
                                                   "," + customerObj.creditCardNo + " " +
                                                   ",'" + customerObj.creditCardName + "' " +
                                                   ",'" + customerObj.creditCardType + "' " +
                                                   ",CAST('" + customerObj.creditCardExp + "' AS DATE) " +
                                                   "," + customerObj.driverLicenseNo + ");";

                    con.Open();
                    SqlCommand custInsert = new SqlCommand(myInsert, con);
                    custInsert.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer successfully added to datebase.");

                    this.Dispose();
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

        public bool verifyCustomer()
        {
            //cmbo restricts creditCardType for validation.
            //dtp restricts creditCardExp for validation.

            if(!verifyString(txt_firstName, "First Name")|| !verifyString(txt_lastName, "Last Name") || !verifyString(txt_streetName, "Street Name")
                || !verifyString(txt_residencySuburb, "Residency Suburb") || !verifyString(txt_residencyState, "Residency Suburb")
                || !verifyString(txt_creditCardName, "Credit Card Name"))
            {
                return false;
            }
            else if(txt_residencyState.TextLength>3)
            {
                MessageBox.Show("Error: Input in 'Residency State' can't be more than 3 chars.\n" +
                                "Please enter a valid and shorter 'Rego NO'\n" +
                                "WA, NSW, QLD, NT.");
                txt_residencyState.Clear();
                txt_residencyState.Focus();
                return false;
            }
            else if((long.Parse(txt_creditCardNo.Text) < 10000000) || (long.Parse(txt_creditCardNo.Text) > 99999999))
            {
                MessageBox.Show("Error: Input in 'Credit Card No' must be 8 digits.\n" +
                                "Please enter a 8 digit Credit Card No.");
                txt_creditCardNo.Clear();
                txt_creditCardNo.Focus();
                return false;
            }
            else if(!int.TryParse(txt_streetNo.Text, out customerObj.streetNo)|| string.IsNullOrWhiteSpace(txt_streetNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Street No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Street No'.");
                txt_streetNo.Clear();
                txt_streetNo.Focus();
                return false;
            }
            else if (!int.TryParse(txt_streetPostcode.Text, out customerObj.streetPostcode) || string.IsNullOrWhiteSpace(txt_streetPostcode.Text))
            {
                MessageBox.Show("ERROR: Input in 'Street Postcode' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Street Postcode'.");
                txt_streetPostcode.Clear();
                txt_streetPostcode.Focus();
                return false;
            }
            else if (!int.TryParse(txt_mobPhone.Text, out customerObj.mobPhone) || string.IsNullOrWhiteSpace(txt_mobPhone.Text))
            {
                MessageBox.Show("ERROR: Input in 'Mobile Phone' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Mobile Phone'.");
                txt_mobPhone.Clear();
                txt_mobPhone.Focus();
                return false;
            }
            else if (!int.TryParse(txt_creditCardNo.Text, out customerObj.creditCardNo) || string.IsNullOrWhiteSpace(txt_creditCardNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Credit Card No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Credit Card No'.");
                txt_creditCardNo.Clear();
                txt_creditCardNo.Focus();
                return false;
            }
            else if (!int.TryParse(txt_driverLicenseNo.Text, out customerObj.driverLicenseNo) || string.IsNullOrWhiteSpace(txt_driverLicenseNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Driver License No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Driver License No'.");
                txt_driverLicenseNo.Clear();
                txt_driverLicenseNo.Focus();
                return false;
            }
            else
            {
                customerObj.firstName = txt_firstName.Text;
                customerObj.lastName = txt_lastName.Text;
                customerObj.streetName = txt_streetName.Text;
                customerObj.residencySuburb = txt_residencySuburb.Text;
                customerObj.residencyState = txt_residencyState.Text;
                customerObj.creditCardName = txt_creditCardName.Text;
                customerObj.creditCardType = cmbo_creditCardType.Text;
                customerObj.creditCardExp = dtp_creditCardExp.Text;
                return true;
            }
        }
    }
}
