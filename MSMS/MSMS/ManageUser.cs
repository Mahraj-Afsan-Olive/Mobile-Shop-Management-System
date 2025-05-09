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
    public partial class ManageUser : Form
    {
        Function fn = new Function();
        String query;
        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textUsername.Text != "" && textPassword.Text != "")
            {
                String user = textUsername.Text;
                String pass = textPassword.Text;
              

                query = "insert into newUser (uname,upass) values('" + user + "', '" + pass + "')";
                fn.setData(query);
            }

            else
            {
                MessageBox.Show("Please fill in all the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
        }
    }
}
