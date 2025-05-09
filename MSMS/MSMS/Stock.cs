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
    public partial class Stock : Form
    {
        Function fn = new Function();
        string query;
        public Stock()
        {
            InitializeComponent();
        }
        int bid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            query = "Select * from newMobile where mid=" + bid + " ";
            DataSet ds = fn.getData(query);

            companylabel.Text = ds.Tables[0].Rows[0][1].ToString();
            Modellabel.Text = ds.Tables[0].Rows[0][2].ToString();
            Ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            Romlabel.Text = ds.Tables[0].Rows[0][4].ToString();
            Memorylabel.Text = ds.Tables[0].Rows[0][5].ToString();
            Displaylabel.Text = ds.Tables[0].Rows[0][6].ToString();
            DisplaySizelabel.Text = ds.Tables[0].Rows[0][7].ToString();
            RearCameralabel.Text = ds.Tables[0].Rows[0][8].ToString();
            ForntCmeralabel.Text = ds.Tables[0].Rows[0][9].ToString();
            OperetingSystemlabel.Text = ds.Tables[0].Rows[0][10].ToString();
            Chipsetlabel.Text = ds.Tables[0].Rows[0][11].ToString();
            SIMlabel.Text = ds.Tables[0].Rows[0][12].ToString();
            Networklabel.Text = ds.Tables[0].Rows[0][13].ToString();
            Securitylabel.Text = ds.Tables[0].Rows[0][14].ToString();
            Pricelabel.Text = ds.Tables[0].Rows[0][15].ToString();
            Quantitylabel.Text = ds.Tables[0].Rows[0][16].ToString();

        }

        private void Stock_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobile ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
