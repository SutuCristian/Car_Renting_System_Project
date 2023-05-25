namespace UI_Forms
{
    partial class CarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDisplayCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnBackCarMenu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarYear = new System.Windows.Forms.TextBox();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbBrown = new System.Windows.Forms.RadioButton();
            this.rdbSilver = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGray = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbFourWheelDrive = new System.Windows.Forms.CheckBox();
            this.ckbSunroof = new System.Windows.Forms.CheckBox();
            this.ckbNavigationSystem = new System.Windows.Forms.CheckBox();
            this.ckbCruiseControl = new System.Windows.Forms.CheckBox();
            this.ckbAutomaticTransmission = new System.Windows.Forms.CheckBox();
            this.ckbAirConditioner = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 114);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(560, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Cars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(437, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(43, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(43, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(43, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(43, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(43, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Options";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Red;
            this.btnAddCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddCar.Location = new System.Drawing.Point(46, 586);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(99, 41);
            this.btnAddCar.TabIndex = 8;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisplayCar
            // 
            this.btnDisplayCar.BackColor = System.Drawing.Color.Red;
            this.btnDisplayCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDisplayCar.Location = new System.Drawing.Point(151, 586);
            this.btnDisplayCar.Name = "btnDisplayCar";
            this.btnDisplayCar.Size = new System.Drawing.Size(86, 42);
            this.btnDisplayCar.TabIndex = 9;
            this.btnDisplayCar.Text = "Display";
            this.btnDisplayCar.UseVisualStyleBackColor = false;
            this.btnDisplayCar.Click += new System.EventHandler(this.btnDisplayCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteCar.Location = new System.Drawing.Point(243, 587);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(96, 41);
            this.btnDeleteCar.TabIndex = 10;
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnBackCarMenu
            // 
            this.btnBackCarMenu.BackColor = System.Drawing.Color.Red;
            this.btnBackCarMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCarMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackCarMenu.Location = new System.Drawing.Point(151, 741);
            this.btnBackCarMenu.Name = "btnBackCarMenu";
            this.btnBackCarMenu.Size = new System.Drawing.Size(86, 37);
            this.btnBackCarMenu.TabIndex = 11;
            this.btnBackCarMenu.Text = "Back";
            this.btnBackCarMenu.UseVisualStyleBackColor = false;
            this.btnBackCarMenu.Click += new System.EventHandler(this.btnBackCarMenu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(851, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Car list";
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(100, 154);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(274, 20);
            this.txtCarBrand.TabIndex = 13;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(100, 184);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(274, 20);
            this.txtCarModel.TabIndex = 14;
            // 
            // txtCarYear
            // 
            this.txtCarYear.Location = new System.Drawing.Point(100, 211);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(274, 20);
            this.txtCarYear.TabIndex = 15;
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(100, 236);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(274, 20);
            this.txtCarPrice.TabIndex = 16;
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(617, 142);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.Size = new System.Drawing.Size(563, 588);
            this.dataGridCars.TabIndex = 19;
            this.dataGridCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCars_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbYellow);
            this.groupBox3.Controls.Add(this.rdbBrown);
            this.groupBox3.Controls.Add(this.rdbSilver);
            this.groupBox3.Controls.Add(this.rdbGreen);
            this.groupBox3.Controls.Add(this.rdbBlue);
            this.groupBox3.Controls.Add(this.rdbRed);
            this.groupBox3.Controls.Add(this.rdbGray);
            this.groupBox3.Controls.Add(this.rdbWhite);
            this.groupBox3.Controls.Add(this.rdbBlack);
            this.groupBox3.Location = new System.Drawing.Point(100, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 144);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(99, 89);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbYellow.TabIndex = 8;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbBrown
            // 
            this.rdbBrown.AutoSize = true;
            this.rdbBrown.Location = new System.Drawing.Point(99, 65);
            this.rdbBrown.Name = "rdbBrown";
            this.rdbBrown.Size = new System.Drawing.Size(55, 17);
            this.rdbBrown.TabIndex = 7;
            this.rdbBrown.TabStop = true;
            this.rdbBrown.Text = "Brown";
            this.rdbBrown.UseVisualStyleBackColor = true;
            // 
            // rdbSilver
            // 
            this.rdbSilver.AutoSize = true;
            this.rdbSilver.Location = new System.Drawing.Point(99, 42);
            this.rdbSilver.Name = "rdbSilver";
            this.rdbSilver.Size = new System.Drawing.Size(51, 17);
            this.rdbSilver.TabIndex = 6;
            this.rdbSilver.TabStop = true;
            this.rdbSilver.Text = "Silver";
            this.rdbSilver.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(99, 20);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 5;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(6, 112);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbBlue.TabIndex = 4;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(6, 89);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 3;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGray
            // 
            this.rdbGray.AutoSize = true;
            this.rdbGray.Location = new System.Drawing.Point(6, 65);
            this.rdbGray.Name = "rdbGray";
            this.rdbGray.Size = new System.Drawing.Size(47, 17);
            this.rdbGray.TabIndex = 2;
            this.rdbGray.TabStop = true;
            this.rdbGray.Text = "Gray";
            this.rdbGray.UseVisualStyleBackColor = true;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(6, 42);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(53, 17);
            this.rdbWhite.TabIndex = 1;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(6, 19);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbFourWheelDrive);
            this.groupBox2.Controls.Add(this.ckbSunroof);
            this.groupBox2.Controls.Add(this.ckbNavigationSystem);
            this.groupBox2.Controls.Add(this.ckbCruiseControl);
            this.groupBox2.Controls.Add(this.ckbAutomaticTransmission);
            this.groupBox2.Controls.Add(this.ckbAirConditioner);
            this.groupBox2.Location = new System.Drawing.Point(100, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 104);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // ckbFourWheelDrive
            // 
            this.ckbFourWheelDrive.AutoSize = true;
            this.ckbFourWheelDrive.Location = new System.Drawing.Point(149, 65);
            this.ckbFourWheelDrive.Name = "ckbFourWheelDrive";
            this.ckbFourWheelDrive.Size = new System.Drawing.Size(109, 17);
            this.ckbFourWheelDrive.TabIndex = 5;
            this.ckbFourWheelDrive.Text = "Four Wheel Drive";
            this.ckbFourWheelDrive.UseVisualStyleBackColor = true;
            this.ckbFourWheelDrive.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbSunroof
            // 
            this.ckbSunroof.AutoSize = true;
            this.ckbSunroof.Location = new System.Drawing.Point(149, 14);
            this.ckbSunroof.Name = "ckbSunroof";
            this.ckbSunroof.Size = new System.Drawing.Size(63, 17);
            this.ckbSunroof.TabIndex = 4;
            this.ckbSunroof.Text = "Sunroof";
            this.ckbSunroof.UseVisualStyleBackColor = true;
            this.ckbSunroof.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbNavigationSystem
            // 
            this.ckbNavigationSystem.AutoSize = true;
            this.ckbNavigationSystem.Location = new System.Drawing.Point(149, 41);
            this.ckbNavigationSystem.Name = "ckbNavigationSystem";
            this.ckbNavigationSystem.Size = new System.Drawing.Size(114, 17);
            this.ckbNavigationSystem.TabIndex = 3;
            this.ckbNavigationSystem.Text = "Navigation System";
            this.ckbNavigationSystem.UseVisualStyleBackColor = true;
            this.ckbNavigationSystem.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbCruiseControl
            // 
            this.ckbCruiseControl.AutoSize = true;
            this.ckbCruiseControl.Location = new System.Drawing.Point(6, 65);
            this.ckbCruiseControl.Name = "ckbCruiseControl";
            this.ckbCruiseControl.Size = new System.Drawing.Size(91, 17);
            this.ckbCruiseControl.TabIndex = 2;
            this.ckbCruiseControl.Text = "Cruise Control";
            this.ckbCruiseControl.UseVisualStyleBackColor = true;
            this.ckbCruiseControl.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbAutomaticTransmission
            // 
            this.ckbAutomaticTransmission.AutoSize = true;
            this.ckbAutomaticTransmission.Location = new System.Drawing.Point(6, 41);
            this.ckbAutomaticTransmission.Name = "ckbAutomaticTransmission";
            this.ckbAutomaticTransmission.Size = new System.Drawing.Size(137, 17);
            this.ckbAutomaticTransmission.TabIndex = 1;
            this.ckbAutomaticTransmission.Text = "Automatic Transmission";
            this.ckbAutomaticTransmission.UseVisualStyleBackColor = true;
            this.ckbAutomaticTransmission.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbAirConditioner
            // 
            this.ckbAirConditioner.AutoSize = true;
            this.ckbAirConditioner.Location = new System.Drawing.Point(6, 17);
            this.ckbAirConditioner.Name = "ckbAirConditioner";
            this.ckbAirConditioner.Size = new System.Drawing.Size(94, 17);
            this.ckbAirConditioner.TabIndex = 0;
            this.ckbAirConditioner.Text = "Air Conditioner";
            this.ckbAirConditioner.UseVisualStyleBackColor = true;
            this.ckbAirConditioner.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Location = new System.Drawing.Point(151, 650);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 41);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 790);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.txtCarYear);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBackCarMenu);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnDisplayCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarsForm";
            this.Text = "Cars";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDisplayCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnBackCarMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarYear;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbBrown;
        private System.Windows.Forms.RadioButton rdbSilver;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbGray;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbFourWheelDrive;
        private System.Windows.Forms.CheckBox ckbSunroof;
        private System.Windows.Forms.CheckBox ckbNavigationSystem;
        private System.Windows.Forms.CheckBox ckbCruiseControl;
        private System.Windows.Forms.CheckBox ckbAutomaticTransmission;
        private System.Windows.Forms.CheckBox ckbAirConditioner;
        private System.Windows.Forms.Button btnRefresh;
    }
}

