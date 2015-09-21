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
            //When form frmCars is loaded the dataset is loaded automatically and the data for the first record is displayed in the controls.

            tblCarTableAdapter1.Fill(hireDataSet1.tblCar);
            updatePosition();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Checking that text box txtVehicleReg is not empty.
                //Updating all changes.

                if (txtVehicleReg.Text != "")
                {
                    this.Validate();
                    this.CarsBindingSource.EndEdit();
                    this.tblCarTableAdapter1.Update(this.hireDataSet1.tblCar);
                    MessageBox.Show("Update successful");
                }

                //If text box txtVehicleReg is empty this message appear on screen. 

                else 
                {
                    MessageBox.Show("Vehicle Registration Number can't be empty");
                }
            }

            //If there is already row with the same value for column VehicleRegNo this message appear on screen.
            //Column VehicleRegNo is a primary key and it must be unique.

            catch (ConstraintException)
            {
                MessageBox.Show("That Vehicle Registration Number already exists");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Populates all text boxes, check box and data time picker with next record and also updates text box txtOrder to current position.

            CarsBindingSource.MoveNext();
            updatePosition();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            //Populates all text boxes, check box and data time picker with previous record and also updates text box txtOrder to current position.

            CarsBindingSource.MovePrevious();
            updatePosition();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            //Populates all text boxes, check box and data time picker with first record and also updates text box txtOrder to current position.

            CarsBindingSource.MoveFirst();
            updatePosition();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            //Populates all text boxes, check box and data time picker with last record and also updates text box txtOrder to current position.

            CarsBindingSource.MoveLast();
            updatePosition();
        }

        private void updatePosition()
        {
            //Populates text box txtOrder with current and total record number.

            txtOrder.Text = CarsBindingSource.Position +1 + " of " + CarsBindingSource.Count;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the program.

            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Opens a form frmSearch.

            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Adding a new row.
                //Populating column VehicleRegNo because it can't be empty, and column Available with 0 (False) because it's by default set to True.
                
                DataRow row = hireDataSet1.tblCar.NewRow();
                row["VehicleRegNo"] = "Regis";
                row["Available "] = 0;
                hireDataSet1.tblCar.Rows.Add(row);
                
                //Row is added to last place, so this is going to show that record.
                CarsBindingSource.MoveLast();
                updatePosition();
            }

            //If there is already row with the same value for column VehicleRegNo this message appear on screen.
            //Column VehicleRegNo is a primary key and it must be unique.

            catch (ConstraintException)
            {
                MessageBox.Show("Vehicle Registration Number 'Regis' already exist");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Deletes current record and shows next record with updated position. 
            //If you are sure you want to delete that record then it's necessary to click Update button. 

            hireDataSet1.tblCar[CarsBindingSource.Position].Delete();
            updatePosition();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Cancels all changes.

            hireDataSet1.RejectChanges();
            CarsBindingSource.ResetBindings(false);
            updatePosition();
        }
    }
}
