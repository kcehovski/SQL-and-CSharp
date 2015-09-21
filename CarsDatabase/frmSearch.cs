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

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //When form frmSearch is loaded combo boxes cboField and cboOperator are going to be populated with data.

            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");
            cboField.SelectedIndex = 0;

            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
            cboOperator.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the program.

            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Checking that text box txtValue is not empty, making connection to database and running the query.
            if (txtValue.Text != "")
            {
                try
                {

                    string sql = String.Format("SELECT VehicleRegNo, Make, EngineSize, DateRegistered, '€' + CAST(RentalPerDay AS varchar) AS RentalPerDay, Available FROM tblCar WHERE {0} {1} @Third", cboField.SelectedItem, cboOperator.SelectedItem);

                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Hire.mdf;Integrated Security=True");
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();


                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Third", txtValue.Text);

                    command.CommandText = sql;
                    command.ExecuteNonQuery();

                    //Creates new data table and populates DataGridView with those records.
                    DataTable table = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(table);
                    tblCarDataGridView.DataSource = table;

                    //If there is no match message will appear.

                    if (tblCarDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no match!");
                    }
                }
                
                //If there is a sql error it will show this message.

                catch (SqlException)
                {
                    MessageBox.Show("Error in your query!");
                }

                //If there is any other error it will show this message.

                catch (Exception)
                {
                    MessageBox.Show("Something is wrong, try again");
                }
            }

            //If text box txtValue is empty this message will appear.

            else
            {
                MessageBox.Show("You need to enter value text!");
            }
        }
    }
}
