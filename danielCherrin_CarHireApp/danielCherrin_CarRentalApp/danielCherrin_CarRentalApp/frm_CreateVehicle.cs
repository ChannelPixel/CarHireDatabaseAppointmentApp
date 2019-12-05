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
    public partial class frm_CreateVehicle : Form
    {

        Vehicle vehicleObj = new Vehicle();

        public frm_CreateVehicle()
        {
            InitializeComponent();
            dtp_regoExp.CustomFormat = "yyyy-MM-dd";
            cmbo_bodyType.SelectedIndex = 0;
        }

        private void btn_cancelForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_confirmForm_Click(object sender, EventArgs e)
        {
            if(verifyVehicle())
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

                    string myInsert = "INSERT INTO[dbo].[Vehicles] " +
                                            "([VIN] " +
                                            ",[manufacturer] " +
                                            ",[model] " +
                                            ",[colour] " +
                                            ",[bodyType] " +
                                            ",[odoCurrent] " +
                                            ",[regoNo] " +
                                            ",[regoExp] " +
                                            ",[dailyRate] " +
                                            ",[hourlyRate] " +
                                            ",[observations] " +
                                            ",[yearOfManuf]) " +
                                       "VALUES " +
                                            "('"+vehicleObj.VIN+"' "+
                                            ",'"+vehicleObj.manufacturer+"' "+
                                            ",'"+vehicleObj.model+"' "+
                                            ",'"+vehicleObj.colour+"' "+
                                            ",'"+vehicleObj.bodyType+"' "+
                                            ","+vehicleObj.odoCurrent+" "+
                                            ",'"+vehicleObj.regoNo+"' "+
                                            ",CAST('"+vehicleObj.regoExp+"' AS DATE) "+
                                            ","+vehicleObj.dailyRate+" "+
                                            ","+vehicleObj.hourlyRate+" "+
                                            ",'"+vehicleObj.observations+"' "+
                                            ","+vehicleObj.yearOfManuf+");";

                    con.Open();
                    SqlCommand custUpd = new SqlCommand(myInsert, con);

                    //Handles duplicate primary keys
                    try
                    {
                        custUpd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle successfully added to database.");

                        this.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("The VIN is a duplicate. \n" +
                                        "Please enter another VIN.");
                        txt_VIN.Clear();
                        txt_VIN.Focus();
                        return;
                    }
                    con.Close();
                    
                }
            }
        }

        public bool verifyString(TextBox textboxS, string label)
        {
            if (string.IsNullOrWhiteSpace(textboxS.Text))
            {
                MessageBox.Show("ERROR: Input in '"+label+"' is null, empty or whitespace\n" +
                                "Please enter a valid '"+label+"'.");
                textboxS.Clear();
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

            if (!verifyString(txt_VIN, "VIN") || !verifyString(txt_manufacturer, "Manufacturer") || !verifyString(txt_model, "Model") || !verifyString(txt_colour, "Colour")
                || !verifyString(txt_regoNo, "Rego No") || !verifyString(txt_observations, "Observations"))
            {
                return false;
            }
            else if(txt_regoNo.TextLength>10)
            {
                MessageBox.Show("Error: Input in 'Rego NO' can't be more than 10 chars.\n" +
                                "Please enter a valid and shorter 'Rego NO'.");
                txt_regoNo.Clear();
                txt_regoNo.Focus();
                return false;
            }
            else if (!int.TryParse(txt_odoCurrent.Text, out vehicleObj.odoCurrent) || string.IsNullOrWhiteSpace(txt_odoCurrent.Text))
            {
                MessageBox.Show("ERROR: Input in 'Odo Current' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Odo Current'.");
                txt_odoCurrent.Clear();
                txt_odoCurrent.Focus();
                return false;
            }
            else if (!double.TryParse(txt_dailyRate.Text, out vehicleObj.dailyRate) || string.IsNullOrWhiteSpace(txt_dailyRate.Text))
            {
                MessageBox.Show("ERROR: Input in 'Daily Rate' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Daily Rate'.");
                txt_dailyRate.Clear();
                txt_dailyRate.Focus();
                return false;
            }
            else if (!double.TryParse(txt_hourlyRate.Text, out vehicleObj.hourlyRate) || string.IsNullOrWhiteSpace(txt_hourlyRate.Text))
            {
                MessageBox.Show("ERROR: Input in 'Hourly Rate' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Hourly Rate'.");
                txt_hourlyRate.Clear();
                txt_hourlyRate.Focus();
                return false;
            }
            else if (!int.TryParse(txt_yearOfManuf.Text, out vehicleObj.yearOfManuf) || string.IsNullOrWhiteSpace(txt_yearOfManuf.Text))
            {
                MessageBox.Show("ERROR: Input in 'Year Of Manuf.' isn't a number or is null/empty/whitespace.\n" +
                                "Please enter a valid 'Year Of Manuf'.");
                txt_yearOfManuf.Clear();
                txt_yearOfManuf.Focus();
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
