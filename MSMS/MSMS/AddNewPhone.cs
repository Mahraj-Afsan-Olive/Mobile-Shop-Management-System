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
    public partial class AddNewPhone : Form
    {
        Function fn = new Function();
        String query;
        public AddNewPhone()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textCompany.Text != "" && textModel.Text != "" && comboRam.Text != "" && comboRom.Text != "" && comboExpandable.Text != "" && comboDisplayType.Text != "" && comboDisplaySize.Text != "" && comboRear.Text != "" && comboFront.Text != "" && comboOS.Text != "" && comboChipset.Text != "" && comboSim.Text != "" && comboNetwork.Text != "" && comboSecurity.Text != "" && textPrice.Text != "" && textQuantity.Text != "")
            {
                String company = textCompany.Text;
                String model = textModel.Text;
                String ram = comboRam.Text;
                String rom = comboRom.Text;
                String expandable = comboExpandable.Text;
                String displayType = comboDisplayType.Text;
                String displaySize = comboDisplaySize.Text;
                String rear = comboRear.Text;
                String front = comboFront.Text;
                String os = comboOS.Text;
                String chipset = comboChipset.Text;
                String sim = comboSim.Text;
                String network = comboNetwork.Text;
                String security = comboSecurity.Text;
                Int64 price = Int64.Parse(textPrice.Text);
                Int64 quantity = Int64.Parse(textQuantity.Text);

                query = "insert into newMobile (cname,mname,ram,rom,expandable,displayType,displaysize,rear,front,os,chipset,sim,network,secure,price,quantity) values('" + company + "', '" + model + "','" + ram + "','" + rom + "','" + expandable + "','" + displayType + "','" + displaySize + "','" + rear + "','" + front + "','" + os + "','" + chipset + "','" + sim + "','" + network + "','" + security + "'," + price + "," + quantity + ")";
                fn.setData(query);
            }

            else
            {
                MessageBox.Show("Please fill in all the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textCompany.Clear();
            textModel.Clear();
            comboRam.SelectedIndex = -1;
            comboRom.SelectedIndex = -1;
            comboExpandable.SelectedIndex = -1;
            comboDisplayType.SelectedIndex = -1;
            comboDisplaySize.SelectedIndex = -1;
            comboRear.SelectedIndex = -1;
            comboFront.SelectedIndex = -1;
            comboOS.SelectedIndex = -1;
            comboChipset.SelectedIndex = -1;
            comboSim.SelectedIndex = -1;
            comboNetwork.SelectedIndex = -1;
            comboSecurity.SelectedIndex = -1;
            textPrice.Clear();
            textQuantity.Clear();
        }

        private void AddNewPhone_Load(object sender, EventArgs e)
        {

        }
    }
}
