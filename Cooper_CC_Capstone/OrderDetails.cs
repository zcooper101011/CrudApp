using Cooper_CC_Capstone.ResturantDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooper_CC_Capstone
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.resturantDataSet.OrderDetails);

        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetailsTableAdapter orderDetailsTableAdapter = new OrderDetailsTableAdapter();

            orderDetailsTableAdapter.Insert(Int32.Parse(txtOrderDetailsId.Text), 
                Int32.Parse(txtOrderDetailsId.Text),
                Int32.Parse(txtOrderDetailPrice.Text), Int32.Parse(txtOrderDetailQuantity.Text));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.orderDetailsTableAdapter.Fill(this.resturantDataSet.OrderDetails);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTableNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTableDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
