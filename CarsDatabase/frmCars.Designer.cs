namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegTextBox = new System.Windows.Forms.TextBox();
            this.CarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet1 = new CarsDatabase.HireDataSet();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.pageTextBox = new System.Windows.Forms.TextBox();
            this.vehicleReg = new System.Windows.Forms.ToolTip(this.components);
            this.make = new System.Windows.Forms.ToolTip(this.components);
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.rentalPerDay = new System.Windows.Forms.ToolTip(this.components);
            this.rentalPerDayTextBox = new System.Windows.Forms.TextBox();
            this.engineSize = new System.Windows.Forms.ToolTip(this.components);
            this.dateRegistered = new System.Windows.Forms.ToolTip(this.components);
            this.registerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.availableCar = new System.Windows.Forms.ToolTip(this.components);
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.tblCarTableAdapter1 = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager1 = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle registration number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date registered";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rental per day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Available";
            // 
            // RegTextBox
            // 
            this.RegTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "VehicleRegNo", true));
            this.RegTextBox.Location = new System.Drawing.Point(173, 123);
            this.RegTextBox.Name = "RegTextBox";
            this.RegTextBox.Size = new System.Drawing.Size(135, 20);
            this.RegTextBox.TabIndex = 7;
            this.vehicleReg.SetToolTip(this.RegTextBox, "Enter vehicle registration number");
            // 
            // CarsBindingSource
            // 
            this.CarsBindingSource.DataMember = "tblCar";
            this.CarsBindingSource.DataSource = this.hireDataSet1;
            // 
            // hireDataSet1
            // 
            this.hireDataSet1.DataSetName = "HireDataSet";
            this.hireDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "EngineSize", true));
            this.engineSizeTextBox.Location = new System.Drawing.Point(173, 192);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(135, 20);
            this.engineSizeTextBox.TabIndex = 9;
            this.engineSize.SetToolTip(this.engineSizeTextBox, "Enter engine size");
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.updateButton.FlatAppearance.BorderSize = 2;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(447, 101);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 39);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addButton.FlatAppearance.BorderSize = 2;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(447, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 37);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatAppearance.BorderSize = 2;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(447, 189);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 38);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.searchButton.FlatAppearance.BorderSize = 2;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(447, 233);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 36);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(447, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 40);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(447, 321);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 36);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.firstButton.FlatAppearance.BorderSize = 2;
            this.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstButton.Location = new System.Drawing.Point(29, 384);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(81, 40);
            this.firstButton.TabIndex = 19;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AutoSize = true;
            this.PreviousButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PreviousButton.FlatAppearance.BorderSize = 2;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Location = new System.Drawing.Point(107, 384);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(81, 40);
            this.PreviousButton.TabIndex = 20;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.AutoSize = true;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.NextButton.FlatAppearance.BorderSize = 2;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(313, 384);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(81, 40);
            this.NextButton.TabIndex = 21;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.lastButton.FlatAppearance.BorderSize = 2;
            this.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastButton.Location = new System.Drawing.Point(391, 384);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(81, 40);
            this.lastButton.TabIndex = 22;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // pageTextBox
            // 
            this.pageTextBox.Location = new System.Drawing.Point(194, 395);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(113, 20);
            this.pageTextBox.TabIndex = 23;
            this.pageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "Make ", true));
            this.makeTextBox.Location = new System.Drawing.Point(173, 156);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(182, 20);
            this.makeTextBox.TabIndex = 24;
            this.make.SetToolTip(this.makeTextBox, "Enter the make of the vehicle");
            // 
            // rentalPerDayTextBox
            // 
            this.rentalPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "RentalPerDay ", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.rentalPerDayTextBox.Location = new System.Drawing.Point(173, 277);
            this.rentalPerDayTextBox.Name = "rentalPerDayTextBox";
            this.rentalPerDayTextBox.Size = new System.Drawing.Size(182, 20);
            this.rentalPerDayTextBox.TabIndex = 28;
            this.rentalPerDay.SetToolTip(this.rentalPerDayTextBox, "Enter the price of rent per day");
            // 
            // registerDateTimePicker
            // 
            this.registerDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarsBindingSource, "DateRegistered ", true));
            this.registerDateTimePicker.Location = new System.Drawing.Point(173, 229);
            this.registerDateTimePicker.Name = "registerDateTimePicker";
            this.registerDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registerDateTimePicker.TabIndex = 25;
            this.dateRegistered.SetToolTip(this.registerDateTimePicker, "Enter the date of registration");
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CarsBindingSource, "Available ", true));
            this.availableCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableCheckBox.Location = new System.Drawing.Point(173, 321);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(12, 11);
            this.availableCheckBox.TabIndex = 29;
            this.availableCar.SetToolTip(this.availableCheckBox, "Is car available?");
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblCarTableAdapter1
            // 
            this.tblCarTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblCarTableAdapter = this.tblCarTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 445);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.rentalPerDayTextBox);
            this.Controls.Add(this.registerDateTimePicker);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.pageTextBox);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(this.RegTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCars";
            this.Text = "TaskA Katarina Cehovski  25/08/2015";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RegTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.TextBox pageTextBox;
        private HireDataSet hireDataSet1;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter1;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource CarsBindingSource;
        private System.Windows.Forms.ToolTip vehicleReg;
        private System.Windows.Forms.ToolTip make;
        private System.Windows.Forms.ToolTip engineSize;
        private System.Windows.Forms.ToolTip dateRegistered;
        private System.Windows.Forms.ToolTip rentalPerDay;
        private System.Windows.Forms.ToolTip availableCar;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.DateTimePicker registerDateTimePicker;
        private System.Windows.Forms.TextBox rentalPerDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
    }
}