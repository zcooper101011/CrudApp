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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resturantDataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resturantDataSet.Orders' table. You can move, or remove it, as needed.
            OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
            ordersTableAdapter.Fill(this.resturantDataSet.Orders);

        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {//OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();

            OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();


            ordersTableAdapter.Insert(Int32.Parse(txtOrdersUserId.Text),
              Convert.ToDateTime(dtnStartTime.Value.Date), 
              Convert.ToDateTime(dtnPickupTime.Value.Date), Convert.ToDateTime(dtnCompleteTime.Value.Date));
        }

        private void btnSearchUserId_Click(object sender, EventArgs e)
        {
            int quantityUserIdToSearch;
            Int32.TryParse(txtSearchUserId.Text, out quantityUserIdToSearch);
            this.ordersTableAdapter.SearchByUserId(this.resturantDataSet.Orders, quantityUserIdToSearch);
        }

        private void btnSearchStartTime_Click(object sender, EventArgs e)
        {
            DateTime startTimeToSearch;
            DateTime.TryParse(txtSearchStartTime.Text, out startTimeToSearch);
            this.ordersTableAdapter.SearchByStartTime(this.resturantDataSet.Orders, startTimeToSearch);
        }

        private void btnSearchPickupTime_Click(object sender, EventArgs e)
        {
            DateTime pickupTimeToSearch;
            DateTime.TryParse(txtSearchPickUpTime.Text, out pickupTimeToSearch);
            this.ordersTableAdapter.SearchByPickUpTime(this.resturantDataSet.Orders, pickupTimeToSearch);
        }

        private void btnSearchCompleteTime_Click(object sender, EventArgs e)
        {
            DateTime completeTimeToSearch;
            DateTime.TryParse(txtSearchCompleteTime.Text, out completeTimeToSearch);
            this.ordersTableAdapter.SearchByCompleteTime(this.resturantDataSet.Orders, completeTimeToSearch);
        }
    }
}
