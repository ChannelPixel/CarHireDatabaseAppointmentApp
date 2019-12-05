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
    public partial class frm_AlterCustomer : Form
    {
        Customer customerObj = new Customer();
        Customer savedCustomer;

        public frm_AlterCustomer(Customer alterCustomer)
        {
            savedCustomer = alterCustomer;
            InitializeComponent();
            dtp_creditCardExp.CustomFormat = "yyyy-MM-dd";

            customerObj.customerNo = savedCustomer.customerNo;
            txt_firstName.Text = savedCustomer.firstName;
            txt_lastName.Text = savedCustomer.lastName;
            txt_streetNo.Text = savedCustomer.streetNo.ToString();
            txt_streetName.Text = savedCustomer.streetName;
            txt_streetPostcode.Text = savedCustomer.streetPostcode.ToString();
            txt_residencySuburb.Text = savedCustomer.residencySuburb;
            txt_residencyState.Text = savedCustomer.residencyState;
            txt_mobPhone.Text = savedCustomer.mobPhone.ToString();
            txt_creditCardNo.Text = savedCustomer.creditCardNo.ToString();
            txt_creditCardName.Text = savedCustomer.creditCardName;
            cmbo_creditCardType.Text = savedCustomer.creditCardType;
            dtp_creditCardExp.Text = savedCustomer.creditCardExp;
            txt_driverLicenseNo.Text = savedCustomer.driverLicenseNo.ToString();
        }

        private void btn_cancelForm_Click(object sender, EventArgs e)
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

                    string myInsert = "UPDATE [dbo].[Customers] SET" +
                                                   "[firstName] = '" + customerObj.firstName + "' "+
                                                   ",[lastName] = '" + customerObj.lastName + "' "+
                                                   ",[streetNo] = " + customerObj.streetNo + " "+
                                                   ",[streetName] = '" + customerObj.streetName + "' "+
                                                   ",[streetPostcode] = " + customerObj.streetPostcode + " "+
                                                   ",[residencySuburb] = '" + customerObj.residencySuburb + "' "+
                                                   ",[residencyState] = '" + customerObj.residencyState + "' "+
                                                   ",[mobPhone] = " + customerObj.mobPhone + " "+
                                                   ",[creditCardNo] = " + customerObj.creditCardNo + " " +
                                                   ",[creditCardName] = '" + customerObj.creditCardName + "' " +
                                                   ",[creditCardType] = '" + customerObj.creditCardType + "' " +
                                                   ",[creditCardExp] = CAST('" + customerObj.creditCardExp + "' AS DATE) " +
                                                   ",[driverLicenseNo] = " + customerObj.driverLicenseNo + " " +
                                      "WHERE [customerNo] = " + customerObj.customerNo + ";";


                    con.Open();
                    SqlCommand custInsert = new SqlCommand(myInsert, con);
                    custInsert.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer successfully altered in datebase.");

                    this.Dispose();
                }
            }
        }

        public bool verifyString(TextBox textboxS, string label, string varString)
        {
            if (string.IsNullOrWhiteSpace(textboxS.Text))
            {
                MessageBox.Show("ERROR: Input in '" + label + "' is null, empty or whitespace\n" +
                                "Please enter a valid '" + label + "'.");
                textboxS.Text = varString;
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

            if (!verifyString(txt_firstName, "First Name", savedCustomer.firstName) || !verifyString(txt_lastName, "Last Name", savedCustomer.lastName) || !verifyString(txt_streetName, "Street Name", savedCustomer.streetName)
                || !verifyString(txt_residencySuburb, "Residency Suburb", savedCustomer.residencySuburb) || !verifyString(txt_residencyState, "Residency Suburb", savedCustomer.residencySuburb)
                || !verifyString(txt_creditCardName, "Credit Card Name", savedCustomer.creditCardName))
            {
                return false;
            }
            else if (txt_residencyState.TextLength > 3)
            {
                MessageBox.Show("Error: Input in 'Residency State' can't be more than 3 chars.\n" +
                                "Please enter a valid and shorter 'Rego NO'\n" +
                                "WA, NSW, QLD, NT.");
                txt_residencyState.Text = savedCustomer.residencyState;
                return false;
            }
            else if ((long.Parse(txt_creditCardNo.Text) < 10000000) || (long.Parse(txt_creditCardNo.Text) > 99999999))
            {
                MessageBox.Show("Error: Input in 'Credit Card No' must be 8 digits.\n" +
                                "Please enter a 8 digit Credit Card No.");
                txt_creditCardNo.Text = savedCustomer.creditCardNo.ToString();
                return false;
            }
            else if (!int.TryParse(txt_streetNo.Text, out customerObj.streetNo) || string.IsNullOrWhiteSpace(txt_streetNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Street No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Street No'.");
                txt_streetNo.Text = savedCustomer.streetNo.ToString();
                return false;
            }
            else if (!int.TryParse(txt_streetPostcode.Text, out customerObj.streetPostcode) || string.IsNullOrWhiteSpace(txt_streetPostcode.Text))
            {
                MessageBox.Show("ERROR: Input in 'Street Postcode' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Street Postcode'.");
                txt_streetPostcode.Text = savedCustomer.streetPostcode.ToString();
                return false;
            }
            else if (!int.TryParse(txt_mobPhone.Text, out customerObj.mobPhone) || string.IsNullOrWhiteSpace(txt_mobPhone.Text))
            {
                MessageBox.Show("ERROR: Input in 'Mobile Phone' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Mobile Phone'.");
                txt_mobPhone.Text = savedCustomer.mobPhone.ToString();
                return false;
            }
            else if (!int.TryParse(txt_creditCardNo.Text, out customerObj.creditCardNo) || string.IsNullOrWhiteSpace(txt_creditCardNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Credit Card No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Credit Card No'.");
                txt_creditCardNo.Text = savedCustomer.creditCardNo.ToString();
                return false;
            }
            else if (!int.TryParse(txt_driverLicenseNo.Text, out customerObj.driverLicenseNo) || string.IsNullOrWhiteSpace(txt_driverLicenseNo.Text))
            {
                MessageBox.Show("ERROR: Input in 'Driver License No' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Driver License No'.");
                txt_driverLicenseNo.Text = savedCustomer.driverLicenseNo.ToString();
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
