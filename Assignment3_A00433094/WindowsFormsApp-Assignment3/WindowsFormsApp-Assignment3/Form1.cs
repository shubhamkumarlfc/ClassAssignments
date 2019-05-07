using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using Serilog;

namespace WindowsFormsApp_Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void assignment3TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.assignment3TableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.assignment3DatabaseDataSet);
            }
            catch (System.Exception ex)
            {
                Log.Information("Exception Caught : " + ex.ToString());
            }
        }

        private Boolean IsValidEmailFormat(string email)
        {
            return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
                }

        private Boolean IsValidPhoneNumber(string phoneNumber)  // Phone number format - (101)101-1011
        {
            return Regex.IsMatch(phoneNumber, "^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        }
        private Boolean IsValidPostalCode(string postalCode) // postal code format b3k2y9 or b3k 2y9
        {
            return Regex.IsMatch(postalCode, "^([A-Za-z]\\d[A-Za-z][]\\d[A-Za-z]\\d)|(^[A-Za-z]\\d[A-Za-z]\\d[A-Za-z]\\d)");
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'assignment3DatabaseDataSet.Assignment3Table' table. You can move, or remove it, as needed.
                this.assignment3TableTableAdapter.Fill(this.assignment3DatabaseDataSet.Assignment3Table);
                Log.Information("Windows form Loaded Successfully.");

                // Displaying total and Current number of records on the form
                currentRecTxtBox.Text = this.assignment3TableBindingSource.Position.ToString();
                totalRecTxtBox.Text = (this.assignment3TableBindingSource.Count - 1).ToString();

                // FOR Finding PRIMARY KEY - using Object of Assingnment3Table
                DataColumn[] dr = this.assignment3DatabaseDataSet.Assignment3Table.PrimaryKey;
                this.primaryKeyTxtBox.Text = dr[0].ColumnName;


                //For Validating the Fields
                Validations();
            }
            catch (System.Exception ex)
            {
                Log.Information("Exception Caught : "+ ex.ToString());
            }
        }


        private void Validations()
        {
            //FOR VALIDATIONS
            if (!IsValidEmailFormat(eMAILTextBox.Text)) {
                errorsTxtBox.Text = "Unsupported Email Format";
                Log.Information("Unsupported Email Format for record number : "+this.assignment3TableBindingSource.Position.ToString());
            }
            else if (!IsValidPhoneNumber(pHONENUMBERTextBox.Text)) {
                errorsTxtBox.Text = "Unsupported Phone Number";
                Log.Information("Unsupported Phone Number for record number : " + this.assignment3TableBindingSource.Position.ToString());
            }
            else if (!IsValidPostalCode(pOSTALCODETextBox.Text)) {
                errorsTxtBox.Text = "Unsupported Postal Code";
                Log.Information("Unsupported Postal Code for record number : " + this.assignment3TableBindingSource.Position.ToString());
            }
            else
            {
                errorsTxtBox.Text = "No Formatting errors";
                Log.Information("No Formatting errors for record number : " + this.assignment3TableBindingSource.Position.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.assignment3TableBindingSource.MoveNext();
                // Updating total and Current number of records on the form
                currentRecTxtBox.Text = this.assignment3TableBindingSource.Position.ToString();
                totalRecTxtBox.Text = (this.assignment3TableBindingSource.Count - 1).ToString();
                Validations();
            }
            catch (System.Exception ex)
            {
                Log.Information("Exception Caught : " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.assignment3TableBindingSource.MovePrevious();
                // Updating total and Current number of records on the form
                currentRecTxtBox.Text = this.assignment3TableBindingSource.Position.ToString();
                totalRecTxtBox.Text = (this.assignment3TableBindingSource.Count - 1).ToString();
                Validations();
            }
            catch (System.Exception ex)
            {
                Log.Information("Exception Caught : " + ex.ToString());
            }
        }

    }
}
