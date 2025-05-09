
namespace MSMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dash_panel1 = new System.Windows.Forms.Panel();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.btnCustomerRecords = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.buttonAddNewPhone = new System.Windows.Forms.Button();
            this.dash_panel2 = new System.Windows.Forms.Panel();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.dash_panel1.SuspendLayout();
            this.dash_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_panel1
            // 
            this.dash_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dash_panel1.Controls.Add(this.buttonManage);
            this.dash_panel1.Controls.Add(this.buttonLogout);
            this.dash_panel1.Controls.Add(this.buttonStock);
            this.dash_panel1.Controls.Add(this.buttonCustomers);
            this.dash_panel1.Controls.Add(this.btnCustomerRecords);
            this.dash_panel1.Controls.Add(this.txtPassword);
            this.dash_panel1.Controls.Add(this.btnCancel);
            this.dash_panel1.Controls.Add(this.btnVerify);
            this.dash_panel1.Controls.Add(this.btnDeletePhone);
            this.dash_panel1.Controls.Add(this.buttonAddNewPhone);
            this.dash_panel1.Location = new System.Drawing.Point(1, 1);
            this.dash_panel1.Name = "dash_panel1";
            this.dash_panel1.Size = new System.Drawing.Size(230, 800);
            this.dash_panel1.TabIndex = 38;
            this.dash_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dash_panel1_Paint);
            // 
            // buttonManage
            // 
            this.buttonManage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManage.Image = ((System.Drawing.Image)(resources.GetObject("buttonManage.Image")));
            this.buttonManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManage.Location = new System.Drawing.Point(12, 227);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(212, 47);
            this.buttonManage.TabIndex = 12;
            this.buttonManage.Text = "   Manage Users";
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click_1);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(54, 468);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(93, 37);
            this.buttonLogout.TabIndex = 45;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonStock.Image")));
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.Location = new System.Drawing.Point(11, 173);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(213, 48);
            this.buttonStock.TabIndex = 44;
            this.buttonStock.Text = "Stock";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomers.Image")));
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(11, 65);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(213, 48);
            this.buttonCustomers.TabIndex = 43;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = false;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // btnCustomerRecords
            // 
            this.btnCustomerRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerRecords.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRecords.Image")));
            this.btnCustomerRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerRecords.Location = new System.Drawing.Point(12, 119);
            this.btnCustomerRecords.Name = "btnCustomerRecords";
            this.btnCustomerRecords.Size = new System.Drawing.Size(213, 48);
            this.btnCustomerRecords.TabIndex = 38;
            this.btnCustomerRecords.Text = "Customer Records";
            this.btnCustomerRecords.UseVisualStyleBackColor = false;
            this.btnCustomerRecords.Click += new System.EventHandler(this.btnCustomerRecords_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(3, 355);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 27);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 29);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(18, 406);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(79, 29);
            this.btnVerify.TabIndex = 40;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhone.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePhone.Image")));
            this.btnDeletePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePhone.Location = new System.Drawing.Point(3, 290);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(213, 48);
            this.btnDeletePhone.TabIndex = 39;
            this.btnDeletePhone.Text = "Delete Phone Records";
            this.btnDeletePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePhone.UseVisualStyleBackColor = false;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // buttonAddNewPhone
            // 
            this.buttonAddNewPhone.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNewPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPhone.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNewPhone.Image")));
            this.buttonAddNewPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewPhone.Location = new System.Drawing.Point(11, 11);
            this.buttonAddNewPhone.Name = "buttonAddNewPhone";
            this.buttonAddNewPhone.Size = new System.Drawing.Size(213, 48);
            this.buttonAddNewPhone.TabIndex = 37;
            this.buttonAddNewPhone.Text = "Add New Phone";
            this.buttonAddNewPhone.UseVisualStyleBackColor = false;
            this.buttonAddNewPhone.Click += new System.EventHandler(this.buttonAddNewPhone_Click_1);
            // 
            // dash_panel2
            // 
            this.dash_panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.dash_panel2.Controls.Add(this.Welcome_label);
            this.dash_panel2.Location = new System.Drawing.Point(237, 1);
            this.dash_panel2.Name = "dash_panel2";
            this.dash_panel2.Size = new System.Drawing.Size(800, 800);
            this.dash_panel2.TabIndex = 39;
            this.dash_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.dash_panel2_Paint);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.Maroon;
            this.Welcome_label.Location = new System.Drawing.Point(174, 207);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(461, 32);
            this.Welcome_label.TabIndex = 11;
            this.Welcome_label.Text = "Mobile Shop Management System";
            this.Welcome_label.Click += new System.EventHandler(this.Welcome_label_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 813);
            this.Controls.Add(this.dash_panel2);
            this.Controls.Add(this.dash_panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dash_panel1.ResumeLayout(false);
            this.dash_panel1.PerformLayout();
            this.dash_panel2.ResumeLayout(false);
            this.dash_panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dash_panel1;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnDeletePhone;
        private System.Windows.Forms.Button btnCustomerRecords;
        private System.Windows.Forms.Button buttonAddNewPhone;
        private System.Windows.Forms.Panel dash_panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Button buttonManage;
    }
}