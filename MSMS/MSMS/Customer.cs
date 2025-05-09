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
    public partial class Customer : Form
    {
        Function fn = new Function();
        String query;
        public Customer()
        {
            InitializeComponent();
        }
        public void setComboBOX(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query); //select model from newMobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtModel.Text != "" && txtImei.Text != "")
            {
                String name = txtName.Text;
                String gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtPhone.Text);
                String email = txtEmail.Text;
                String address = txtAddress.Text;
                String compamy = txtCompany.Text;
                String model = txtModel.Text;
                String imei = txtImei.Text;

                query = "insert into customerPurchase (cname,gender,contact,email,caddress,company,model,imei) values ('" + name + "', '" + gender + "', '" + contact + "', '" + email + "', '" + address + "', '" + compamy + "', '" + model + "', '" + imei + "')";
                fn.setData(query);

                txtName.Clear();
                txtGender.SelectedIndex = -1;
                txtPhone.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtImei.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCompany_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String cname = txtCompany.Text;
            query = "select mname from newMobile where cname='" + cname + "'";
            setComboBOX(query, txtModel);
        }

        private void txtModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            query = "select * from newMobile where mname='" + txtModel.Text + "'";
            DataSet ds = fn.getData(query);

            Ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            Romlabel.Text = ds.Tables[0].Rows[0][4].ToString();
            Memorylabel.Text = ds.Tables[0].Rows[0][5].ToString();
            Displaylabel.Text = ds.Tables[0].Rows[0][6].ToString();
            dslabel.Text = ds.Tables[0].Rows[0][7].ToString();
            RearCameralabel.Text = ds.Tables[0].Rows[0][8].ToString();
            ForntCmeralabel.Text = ds.Tables[0].Rows[0][9].ToString();
            osslabel.Text = ds.Tables[0].Rows[0][10].ToString();
            chiplabel.Text = ds.Tables[0].Rows[0][11].ToString();
            siimlabel.Text = ds.Tables[0].Rows[0][12].ToString();
            netlabel.Text = ds.Tables[0].Rows[0][13].ToString();
            Securitylabel.Text = ds.Tables[0].Rows[0][14].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][15].ToString();
        }

        private void Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct cname from newMobile";
            setComboBOX(query, txtCompany);
        }
    }
}
