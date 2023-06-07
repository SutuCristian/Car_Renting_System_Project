namespace UI_Forms
{
    partial class RentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.dataGridRentedCars = new System.Windows.Forms.DataGridView();
            this.btnBackCarMenu = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridAvailableCars = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 114);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(562, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rent Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(416, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(36, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client\'s Email adress";
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(199, 175);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(138, 20);
            this.txtEmailClient.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 375);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(36, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(36, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(36, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Car\'s Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(199, 216);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(138, 20);
            this.txtBrand.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(36, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Car\'s Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(199, 259);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(138, 20);
            this.txtModel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(36, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Availability";
            // 
            // cmbAvailability
            // 
            this.cmbAvailability.FormattingEnabled = true;
            this.cmbAvailability.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbAvailability.Location = new System.Drawing.Point(184, 515);
            this.cmbAvailability.Name = "cmbAvailability";
            this.cmbAvailability.Size = new System.Drawing.Size(138, 21);
            this.cmbAvailability.TabIndex = 13;
            // 
            // dataGridRentedCars
            // 
            this.dataGridRentedCars.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRentedCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRentedCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRentedCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRentedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRentedCars.EnableHeadersVisualStyles = false;
            this.dataGridRentedCars.GridColor = System.Drawing.Color.Red;
            this.dataGridRentedCars.Location = new System.Drawing.Point(887, 130);
            this.dataGridRentedCars.Name = "dataGridRentedCars";
            this.dataGridRentedCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRentedCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridRentedCars.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRentedCars.Size = new System.Drawing.Size(343, 588);
            this.dataGridRentedCars.TabIndex = 20;
            // 
            // btnBackCarMenu
            // 
            this.btnBackCarMenu.BackColor = System.Drawing.Color.Red;
            this.btnBackCarMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCarMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackCarMenu.Location = new System.Drawing.Point(141, 681);
            this.btnBackCarMenu.Name = "btnBackCarMenu";
            this.btnBackCarMenu.Size = new System.Drawing.Size(86, 37);
            this.btnBackCarMenu.TabIndex = 21;
            this.btnBackCarMenu.Text = "Back";
            this.btnBackCarMenu.UseVisualStyleBackColor = false;
            this.btnBackCarMenu.Click += new System.EventHandler(this.btnBackCarMenu_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Location = new System.Drawing.Point(328, 508);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 37);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(141, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Rent";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridAvailableCars
            // 
            this.dataGridAvailableCars.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAvailableCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAvailableCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAvailableCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAvailableCars.EnableHeadersVisualStyles = false;
            this.dataGridAvailableCars.GridColor = System.Drawing.Color.Red;
            this.dataGridAvailableCars.Location = new System.Drawing.Point(466, 130);
            this.dataGridAvailableCars.Name = "dataGridAvailableCars";
            this.dataGridAvailableCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAvailableCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridAvailableCars.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridAvailableCars.Size = new System.Drawing.Size(343, 588);
            this.dataGridAvailableCars.TabIndex = 24;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 751);
            this.Controls.Add(this.dataGridAvailableCars);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBackCarMenu);
            this.Controls.Add(this.dataGridRentedCars);
            this.Controls.Add(this.cmbAvailability);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEmailClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "RentForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRentedCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.DataGridView dataGridRentedCars;
        private System.Windows.Forms.Button btnBackCarMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridAvailableCars;
    }
}