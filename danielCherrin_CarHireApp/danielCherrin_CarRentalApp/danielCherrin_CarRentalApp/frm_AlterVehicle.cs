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
    public partial class frm_AlterVehicle : Form
    {

        Vehicle vehicleObj = new Vehicle();
        Vehicle savedVehicle;

        public frm_AlterVehicle(Vehicle alterVehicle)
        {
            savedVehicle = alterVehicle;
            InitializeComponent();
            dtp_regoExp.CustomFormat = "yyyy-MM-dd";

            vehicleObj.VIN = savedVehicle.VIN;
            txt_VIN.Text = savedVehicle.VIN;
            txt_manufacturer.Text = savedVehicle.manufacturer;
            txt_model.Text = savedVehicle.model;
            txt_colour.Text = savedVehicle.colour;
            cmbo_bodyType.Text = savedVehicle.bodyType;
            txt_odoCurrent.Text = savedVehicle.odoCurrent.ToString();
            txt_regoNo.Text = savedVehicle.regoNo;
            dtp_regoExp.Text = savedVehicle.regoExp;
            txt_dailyRate.Text = savedVehicle.dailyRate.ToString();
            txt_hourlyRate.Text = savedVehicle.hourlyRate.ToString();
            txt_observations.Text = savedVehicle.observations;
            txt_yearOfManuf.Text = savedVehicle.yearOfManuf.ToString();
        }

        private void btn_cancelForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_confirmForm_Click(object sender, EventArgs e)
        {
            if (verifyVehicle())
            {
                string stringyBoi = "The information you have provided is :\n";
                stringyBoi += "\nVIN - " + vehicleObj.VIN;
                stringyBoi += "\nManufacturer - " + vehicleObj.manufacturer;
                stringyBoi += "\nModel - " + vehicleObj.model;
                stringyBoi += "\nColour - " + vehicleObj.colour;
                stringyBoi += "\nBody Type - " + vehicleObj.bodyType;
                stringyBoi += "\nOdoCurrent - " + vehicleObj.odoCurrent.ToString();
                stringyBoi += "\nRego No - " + vehicleObj.regoNo;
                stringyBoi += "\nRego Exp - " + vehicleObj.regoExp;
                stringyBoi += "\nDaily Rate - " + vehicleObj.dailyRate.ToString();
                stringyBoi += "\nHourly Rate - " + vehicleObj.hourlyRate.ToString();
                stringyBoi += "\nYear Of Manuf - " + vehicleObj.yearOfManuf.ToString();
                stringyBoi += "\nObservations - \n\n" + vehicleObj.observations + "\n\n";
                stringyBoi += "Create Vehicle using information?";

                DialogResult result;
                result = MessageBox.Show(stringyBoi, "Vehicle Obj Information.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(connectionStr.conn);

                    string myInsert = "UPDATE [dbo].[Vehicles] SET" +
                                                   "[manufacturer] = '" + vehicleObj.manufacturer + "' " +
                                                   ",[model] = '" + vehicleObj.model + "' " +
                                                   ",[colour] = '" + vehicleObj.colour + "' " +
                                                   ",[bodyType] = '" + vehicleObj.bodyType + "' " +
                                                   ",[odoCurrent] = " + vehicleObj.odoCurrent + " " +
                                                   ",[regoNo] = '" + vehicleObj.regoNo + "' " +
                                                   ",[regoExp] = CAST('" + vehicleObj.regoExp + "' AS DATE) " +
                                                   ",[dailyRate] = " + vehicleObj.dailyRate + " " +
                                                   ",[hourlyRate] = " + vehicleObj.hourlyRate + " " +
                                                   ",[yearOfManuf] = " + vehicleObj.yearOfManuf + " " +
                                                   ",[observations] = '" + vehicleObj.observations + "' " +
                                      "WHERE [VIN] = " + vehicleObj.VIN + ";";


                    con.Open();
                    SqlCommand custInsert = new SqlCommand(myInsert, con);
                    custInsert.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer successfully altered to datebase.");
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

        public bool verifyVehicle()
        {
            //combobox(bodyType) limits to verify string
            //dtp(regoExp) limits to verify string

            if (!verifyString(txt_VIN, "VIN", savedVehicle.VIN) || !verifyString(txt_manufacturer, "Manufacturer", savedVehicle.manufacturer) || !verifyString(txt_model, "Model", savedVehicle.model) || !verifyString(txt_colour, "Colour", savedVehicle.colour)
                || !verifyString(txt_regoNo, "Rego No", savedVehicle.regoNo) || !verifyString(txt_observations, "Observations", savedVehicle.observations))
            {
                return false;
            }
            else if (txt_regoNo.TextLength > 10)
            {
                MessageBox.Show("Error: Input in 'Rego NO' can't be more than 10 chars.\n" +
                                "Please enter a valid and shorter 'Rego NO'.");
                txt_regoNo.Text = savedVehicle.regoNo;
                return false;
            }
            else if (!int.TryParse(txt_odoCurrent.Text, out vehicleObj.odoCurrent) || string.IsNullOrWhiteSpace(txt_odoCurrent.Text))
            {
                MessageBox.Show("ERROR: Input in 'Odo Current' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Odo Current'.");
                txt_odoCurrent.Text = savedVehicle.odoCurrent.ToString();
                return false;
            }
            else if (!double.TryParse(txt_dailyRate.Text, out vehicleObj.dailyRate) || string.IsNullOrWhiteSpace(txt_dailyRate.Text))
            {
                MessageBox.Show("ERROR: Input in 'Daily Rate' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Daily Rate'.");
                txt_dailyRate.Text = savedVehicle.dailyRate.ToString();
                return false;
            }
            else if (!double.TryParse(txt_hourlyRate.Text, out vehicleObj.hourlyRate) || string.IsNullOrWhiteSpace(txt_hourlyRate.Text))
            {
                MessageBox.Show("ERROR: Input in 'Hourly Rate' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Hourly Rate'.");
                txt_hourlyRate.Text = savedVehicle.hourlyRate.ToString();
                return false;
            }
            else if (!int.TryParse(txt_yearOfManuf.Text, out vehicleObj.yearOfManuf) || string.IsNullOrWhiteSpace(txt_yearOfManuf.Text))
            {
                MessageBox.Show("ERROR: Input in 'Year Of Manuf.' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Year Of Manuf'.");
                txt_yearOfManuf.Text = savedVehicle.yearOfManuf.ToString();
                return false;
            }
            else
            {
                vehicleObj.VIN = txt_VIN.Text;
                vehicleObj.manufacturer = txt_manufacturer.Text;
                vehicleObj.model = txt_model.Text;
                vehicleObj.colour = txt_colour.Text;
                vehicleObj.bodyType = cmbo_bodyType.Text;
                vehicleObj.regoNo = txt_regoNo.Text;
                vehicleObj.regoExp = dtp_regoExp.Text;
                vehicleObj.observations = txt_observations.Text;
                return true;
            }
        }
    }
}
