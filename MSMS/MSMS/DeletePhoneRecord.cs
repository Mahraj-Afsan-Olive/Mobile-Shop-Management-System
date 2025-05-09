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
    public partial class DeletePhoneRecord : Form
    {
        Function fn = new Function();
        String query;
        public DeletePhoneRecord()
        {
            InitializeComponent();
        }

        int bid;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from newMobile where mid= " + bid + " ";
            if (MessageBox.Show("Deleting Record of " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                fn.setData(query);
            }

        }

        private void DeletePhoneRecord_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            query = "Start * from newMobile where cname like'" + txtSearch.Text + "%' or mname like ' " + txtSearch.Text + "%' ";
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];
        }
        Boolean flag;
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                flag = false;
                labelTOSET.Text = "Enter Company:";
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                flag = true;
                labelTOSET.Text = "Enter Model:";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from newMobile where cname like'" + txtSearch.Text+"%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from newMobile where mname like'" + txtSearch.Text+"%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }
    }
}
