namespace UI_Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarsMenu = new System.Windows.Forms.Button();
            this.btnClientsMenu = new System.Windows.Forms.Button();
            this.btnRentMenu = new System.Windows.Forms.Button();
            this.btnDashboardMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 114);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(562, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Menu";
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
            // btnCarsMenu
            // 
            this.btnCarsMenu.BackColor = System.Drawing.Color.Red;
            this.btnCarsMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarsMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCarsMenu.Location = new System.Drawing.Point(40, 140);
            this.btnCarsMenu.Name = "btnCarsMenu";
            this.btnCarsMenu.Size = new System.Drawing.Size(108, 43);
            this.btnCarsMenu.TabIndex = 1;
            this.btnCarsMenu.Text = "Cars";
            this.btnCarsMenu.UseVisualStyleBackColor = false;
            this.btnCarsMenu.Click += new System.EventHandler(this.btnCarsMenu_Click);
            // 
            // btnClientsMenu
            // 
            this.btnClientsMenu.BackColor = System.Drawing.Color.Red;
            this.btnClientsMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClientsMenu.Location = new System.Drawing.Point(308, 140);
            this.btnClientsMenu.Name = "btnClientsMenu";
            this.btnClientsMenu.Size = new System.Drawing.Size(108, 43);
            this.btnClientsMenu.TabIndex = 2;
            this.btnClientsMenu.Text = "Clients";
            this.btnClientsMenu.UseVisualStyleBackColor = false;
            this.btnClientsMenu.Click += new System.EventHandler(this.btnClientsMenu_Click);
            // 
            // btnRentMenu
            // 
            this.btnRentMenu.BackColor = System.Drawing.Color.Red;
            this.btnRentMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRentMenu.Location = new System.Drawing.Point(557, 140);
            this.btnRentMenu.Name = "btnRentMenu";
            this.btnRentMenu.Size = new System.Drawing.Size(113, 43);
            this.btnRentMenu.TabIndex = 3;
            this.btnRentMenu.Text = "Rent";
            this.btnRentMenu.UseVisualStyleBackColor = false;
            this.btnRentMenu.Click += new System.EventHandler(this.btnRentMenu_Click);
            // 
            // btnDashboardMenu
            // 
            this.btnDashboardMenu.BackColor = System.Drawing.Color.Red;
            this.btnDashboardMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardMenu.Location = new System.Drawing.Point(1096, 139);
            this.btnDashboardMenu.Name = "btnDashboardMenu";
            this.btnDashboardMenu.Size = new System.Drawing.Size(122, 43);
            this.btnDashboardMenu.TabIndex = 4;
            this.btnDashboardMenu.Text = "Dashboard";
            this.btnDashboardMenu.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(580, 626);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(145, 54);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 329);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.Red;
            this.btnReturnMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Location = new System.Drawing.Point(824, 142);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(122, 41);
            this.btnReturnMenu.TabIndex = 7;
            this.btnReturnMenu.Text = "Return";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 730);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDashboardMenu);
            this.Controls.Add(this.btnRentMenu);
            this.Controls.Add(this.btnClientsMenu);
            this.Controls.Add(this.btnCarsMenu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarsMenu;
        private System.Windows.Forms.Button btnClientsMenu;
        private System.Windows.Forms.Button btnRentMenu;
        private System.Windows.Forms.Button btnDashboardMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturnMenu;
    }
}

