using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMS
{
    public partial class Dashboard : Form
    {
       
        public Dashboard()
        {
            InitializeComponent();
        }

        String username;
        public Dashboard(String s)
        {
            InitializeComponent();
            username = s;
        }
        public void loadform(object Form)
        {
            if (this.dash_panel2.Controls.Count > 0)
                this.dash_panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dash_panel2.Controls.Add(f);
            this.dash_panel2.Tag = f;
            f.Show();
        }
      

        private void buttonAddNewPhone_Click_1(object sender, EventArgs e)
        {
            loadform(new AddNewPhone());
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            loadform(new Customer());
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            loadform(new Stock());
        }

        private void btnCustomerRecords_Click(object sender, EventArgs e)
        {
            loadform(new CustomerRecords());
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            loadform(new DeletePhoneRecord());
            dash_panel2.Enabled = false;
            enableDisable(true, true, true);
        }
        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "admin")
            {
                dash_panel2.Enabled = true;
                dash_panel2.Visible = true;
                dash_panel2.BringToFront();
                enableDisable(false, false, false);
                txtPassword.Clear();
            }
            else
            {
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dash_panel2.Enabled = true;
            enableDisable(false, false, false);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            if (username!="admin")
            {
                buttonAddNewPhone.Hide();
                btnDeletePhone.Hide();
                btnVerify.Hide();
                btnCancel.Hide();
                txtPassword.Hide();
                buttonManage.Hide();
                
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAddNewPhone_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void buttonManage_Click_1(object sender, EventArgs e)
        {
            loadform(new ManageUser());
        }

        private void dash_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void dash_panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
