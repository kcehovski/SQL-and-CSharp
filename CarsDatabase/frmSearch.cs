﻿using System;
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
            fieldComboBox.Items.Add("Make");
            fieldComboBox.Items.Add("EngineSize");
            fieldComboBox.Items.Add("RentalPerDay");
            fieldComboBox.Items.Add("Available");
            fieldComboBox.SelectedIndex = 0;

            operatorComboBox.Items.Add("=");
            operatorComboBox.Items.Add("<");
            operatorComboBox.Items.Add(">");
            operatorComboBox.Items.Add("<=");
            operatorComboBox.Items.Add(">=");
            operatorComboBox.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (valueTextBox.Text != "")
            {
                try
                {
                    string sql = String.Format("SELECT VehicleRegNo, Make, EngineSize, DateRegistered, '€' + CAST(RentalPerDay AS varchar) AS RentalPerDay, Available FROM tblCar WHERE {0} {1} @Third", fieldComboBox.SelectedItem, operatorComboBox.SelectedItem);

                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Hire.mdf;Integrated Security=True");
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();


                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Third", valueTextBox.Text);

                    command.CommandText = sql;
                    command.ExecuteNonQuery();

                    DataTable table = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(table);
                    tblCarDataGridView.DataSource = table;

                    if (tblCarDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no match!");
                    }
                }

                catch (SqlException)
                {
                    MessageBox.Show("Error in your query!");
                }

                catch (Exception)
                {
                    MessageBox.Show("Somthing is wrong, try again");
                }
            }

            else
            {
                MessageBox.Show("You need to enter value text!");
            }
        }
    }
}
