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

namespace MSMS
{
    public partial class Login : Form
    {

        Function fn = new Function();
        String query;
       

        public Login()
        {
            InitializeComponent();
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {



            query = "select * from newUser where uname='" + textBox_UN.Text + "' and upass='" + textBox_PW.Text + "'";
            DataSet ds = fn.getData(query);

            if (textBox_UN.Text == "admin" && textBox_PW.Text == "admin")
            {
                Dashboard d = new Dashboard(textBox_UN.Text);
                this.Hide();
                d.Show();
            }

            else if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["upass"].ToString() == textBox_PW.Text)
            {
                Dashboard d = new Dashboard();
                this.Hide();
                d.Show();
            }

            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_UN.Clear();
            textBox_PW.Clear();
            textBox_UN.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_PW.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_PW.UseSystemPasswordChar = true;
            }
        }

        private void textBox_UN_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_UN.Text == "User Name")
            {
                textBox_UN.Text = null;
            }
        }

        private void textBox_UN_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_UN.Text == "")
            {
                textBox_UN.Text = "User Name";
            }
        }

        private void textBox_PW_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_PW.Text == "Password")
            {
                textBox_PW.Text = null;
            }
        }

        private void textBox_PW_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_PW.Text == "")
            {
                textBox_PW.Text = "Password";
            }
        }
    }
}
