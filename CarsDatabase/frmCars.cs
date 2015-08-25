using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }


        private void frmCars_Load(object sender, EventArgs e)
        {
            
            tblCarTableAdapter1.Fill(hireDataSet1.tblCar);
            updatePosition();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (RegTextBox.Text != "")
                {
                    this.Validate();
                    this.CarsBindingSource.EndEdit();
                    this.tblCarTableAdapter1.Update(this.hireDataSet1.tblCar);
                    MessageBox.Show("Update successful");
                }

                else
                {
                    MessageBox.Show("Vehicle Registration Number can't be empty");
                }
            }

            catch (ConstraintException)
            {
                MessageBox.Show("That Vehicle Registration Number already exists");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MoveNext();
            updatePosition();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MovePrevious();
            updatePosition();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MoveFirst();
            updatePosition();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            CarsBindingSource.MoveLast();
            updatePosition();
        }

        private void updatePosition()
        { 
            pageTextBox.Text = CarsBindingSource.Position +1 + " of " + CarsBindingSource.Count;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = hireDataSet1.tblCar.NewRow();
                row["VehicleRegNo"] = "Registration number";
                row["Available "] = 0;
                hireDataSet1.tblCar.Rows.Add(row);
                
                CarsBindingSource.MoveLast();
                updatePosition();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Vehicle Registration Number 'Registration number' already exist");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            hireDataSet1.tblCar[CarsBindingSource.Position].Delete();
            
            updatePosition();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hireDataSet1.RejectChanges();
            CarsBindingSource.ResetBindings(false);
            updatePosition();
        }
    }
}
